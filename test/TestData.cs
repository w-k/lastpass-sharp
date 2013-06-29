namespace LastPass.Test
{
    static class TestData
    {
        public static readonly string[] ChunkIds =
            {
                "LPAV", "ATVR", "ENCU", "CBCU", "BBTE", "IPTE", "WMTE", "ANTE", "DOTE", "FETE",
                "FUTE", "SYTE", "WOTE", "TATE", "WPTE", "SPMT", "NMAC", "EQDN", "URUL", "ENDM"
            };

        public static readonly string BlobBase64 =
            "TFBBVgAAAAE2QVRWUgAAAAEwRU5DVQAAAEYhMTFWRWNYVWd6UWtqbGtqcHZUZnJH" +
            "dz09fFhSSWFVV1BiVDNFd1FCVkJFRjFlQlNMMjdtZnVxVWJmYUJXckJid3lYV0U9" +
            "Q0JDVQAAAAExQkJURQAAAAwtNjIxNjk5NjYwMDBJUFRFAAAADC02MjE2OTk2NjAw" +
            "MFdNVEUAAAAMLTYyMTY5OTY2MDAwQU5URQAAAAwtNjIxNjk5NjYwMDBET1RFAAAA" +
            "DC02MjE2OTk2NjAwMEZFVEUAAAAMLTYyMTY5OTY2MDAwRlVURQAAAAwtNjIxNjk5" +
            "NjYwMDBTWVRFAAAADC02MjE2OTk2NjAwMFdPVEUAAAAMLTYyMTY5OTY2MDAwVEFU" +
            "RQAAAAwtNjIxNjk5NjYwMDBXUFRFAAAAATBTUE1UAAAALQAAAAEwAAAAATAAAAAB" +
            "MAAAAAEwAAAAATAAAAABMQAAAAExAAAAATAAAAABME5NQUMAAAABMEVRRE4AAAAl" +
            "AAAAATEAAAAcNjE2ZDY1NzI2OTc0NzI2MTY0NjUyZTYzNmY2ZEVRRE4AAAApAAAA" +
            "ATEAAAAgNzQ2NDYxNmQ2NTcyNjk3NDcyNjE2NDY1MmU2MzZmNmRFUUROAAAAKwAA" +
            "AAEyAAAAIjYyNjE2ZTZiNmY2NjYxNmQ2NTcyNjk2MzYxMmU2MzZmNmRFUUROAAAA" +
            "GQAAAAEyAAAAEDYyNmY2NjYxMmU2MzZmNmRFUUROAAAAGQAAAAEyAAAAEDZkNjI2" +
            "ZTYxMmU2MzZmNmRFUUROAAAAHQAAAAEyAAAAFDc1NzM2NTYzNjY2ZjJlNjM2ZjZk" +
            "RVFETgAAAB0AAAABMwAAABQ3MzcwNzI2OTZlNzQyZTYzNmY2ZEVRRE4AAAAjAAAA" +
            "ATMAAAAaNzM3MDcyNjk2ZTc0NzA2MzczMmU2MzZmNmRFUUROAAAAHQAAAAEzAAAA" +
            "FDZlNjU3ODc0NjU2YzJlNjM2ZjZkRVFETgAAAB8AAAABNAAAABY3OTZmNzU3NDc1" +
            "NjI2NTJlNjM2ZjZkRVFETgAAAB0AAAABNAAAABQ2NzZmNmY2NzZjNjUyZTYzNmY2" +
            "ZEVRRE4AAAAbAAAAATUAAAASNjE3MDcwNmM2NTJlNjM2ZjZkRVFETgAAAB0AAAAB" +
            "NQAAABQ2OTYzNmM2Zjc1NjQyZTYzNmY2ZEVRRE4AAAAlAAAAATYAAAAcNzc2NTZj" +
            "NmM3MzY2NjE3MjY3NmYyZTYzNmY2ZEVRRE4AAAAVAAAAATYAAAAMNzc2NjJlNjM2" +
            "ZjZkRVFETgAAAC8AAAABNwAAACY3MzZmNzU3NDY4NjU3MjZlNjM2ZjZkNzA2MTZl" +
            "NzkyZTYzNmY2ZEVRRE4AAAAlAAAAATcAAAAcNzM2Zjc1NzQ2ODY1NzI2ZTYzNmYy" +
            "ZTYzNmY2ZEVRRE4AAAAsAAAAAjEyAAAAIjYxNjM2MzZmNzU2ZTc0NmY2ZTZjNjk2" +
            "ZTY1MmU2MzZmNmRFUUROAAAAGgAAAAIxMgAAABA2MzY5NzQ2OTJlNjM2ZjZkRVFE" +
            "TgAAACIAAAACMTIAAAAYNjM2OTc0Njk2MjYxNmU2YjJlNjM2ZjZkRVFETgAAACQA" +
            "AAACMTIAAAAaNjM2OTc0Njk2MzYxNzI2NDczMmU2MzZmNmRFUUROAAAAGgAAAAIy" +
            "MgAAABA2MzZlNjU3NDJlNjM2ZjZkRVFETgAAAB4AAAACMjIAAAAUNjM2ZTY1NzQ3" +
            "NDc2MmU2MzZmNmRFUUROAAAAGAAAAAIyMgAAAA42MzZmNmQyZTYzNmY2ZEVRRE4A" +
            "AAAiAAAAAjIyAAAAGDY0NmY3NzZlNmM2ZjYxNjQyZTYzNmY2ZEVRRE4AAAAaAAAA" +
            "AjIyAAAAEDZlNjU3NzczMmU2MzZmNmRFUUROAAAAHgAAAAIyMgAAABQ3MzY1NjE3" +
            "MjYzNjgyZTYzNmY2ZEVRRE4AAAAeAAAAAjIyAAAAFDc1NzA2YzZmNjE2NDJlNjM2" +
            "ZjZkRVFETgAAAC4AAAACMzIAAAAkNjI2MTZlNjE2ZTYxNzI2NTcwNzU2MjZjNjk2" +
            "MzJlNjM2ZjZkRVFETgAAABgAAAACMzIAAAAONjc2MTcwMmU2MzZmNmRFUUROAAAA" +
            "IAAAAAIzMgAAABY2ZjZjNjQ2ZTYxNzY3OTJlNjM2ZjZkRVFETgAAACQAAAACMzIA" +
            "AAAaNzA2OTcwNjU3MjZjNjk2ZDY1MmU2MzZmNmRFUUROAAAAGgAAAAI0MgAAABA2" +
            "MjY5NmU2NzJlNjM2ZjZkRVFETgAAACAAAAACNDIAAAAWNjg2Zjc0NmQ2MTY5NmMy" +
            "ZTYzNmY2ZEVRRE4AAAAaAAAAAjQyAAAAEDZjNjk3NjY1MmU2MzZmNmRFUUROAAAA" +
            "JAAAAAI0MgAAABo2ZDY5NjM3MjZmNzM2ZjY2NzQyZTYzNmY2ZEVRRE4AAAAYAAAA" +
            "AjQyAAAADjZkNzM2ZTJlNjM2ZjZkRVFETgAAACIAAAACNDIAAAAYNzA2MTczNzM3" +
            "MDZmNzI3NDJlNmU2NTc0RVFETgAAABwAAAACNTIAAAASNzU2MTMyNjc2ZjJlNjM2" +
            "ZjZkRVFETgAAABgAAAACNTIAAAAONzU2MTZjMmU2MzZmNmRFUUROAAAAHgAAAAI1" +
            "MgAAABQ3NTZlNjk3NDY1NjQyZTYzNmY2ZEVRRE4AAAAiAAAAAjgyAAAAGDZmNzY2" +
            "NTcyNzQ3NTcyNjUyZTYzNmY2ZEVRRE4AAAAcAAAAAjgyAAAAEjc5NjE2ODZmNmYy" +
            "ZTYzNmY2ZEVRRE4AAAAkAAAAAjkyAAAAGjdhNmY2ZTY1NjE2YzYxNzI2ZDJlNjM2" +
            "ZjZkRVFETgAAACIAAAACOTIAAAAYN2E2ZjZlNjU2YzYxNjI3MzJlNjM2ZjZkRVFE" +
            "TgAAABsAAAADODQyAAAAEDYxNzY2ZjZlMmU2MzZmNmRFUUROAAAAIwAAAAM4NDIA" +
            "AAAYNzk2Zjc1NzI2MTc2NmY2ZTJlNjM2ZjZkRVFETgAAACwAAAAEMTQ3NAAAACAz" +
            "MTM4MzAzMDYzNmY2ZTc0NjE2Mzc0NzMyZTYzNmY2ZEVRRE4AAAAqAAAABDE0NzQA" +
            "AAAeMzgzMDMwNjM2ZjZlNzQ2MTYzNzQ3MzJlNjM2ZjZkRVFETgAAACAAAAAEMjAw" +
            "MAAAABQ2MTZkNjE3YTZmNmUyZTYzNmY2ZEVRRE4AAAAkAAAABDIwMDAAAAAYNjE2" +
            "ZDYxN2E2ZjZlMmU2MzZmMmU3NTZiRVFETgAAADIAAAAEMjAxMAAAACY2NTc4NzA3" +
            "MjY1NzM3MzJkNzM2MzcyNjk3MDc0NzMyZTYzNmY2ZEVRRE4AAAAqAAAABDIwMTAA" +
            "AAAeNmQ2NTY0NjM2ZjY4NjU2MTZjNzQ2ODJlNjM2ZjZkRVFETgAAABoAAAAEMjAx" +
            "MgAAAA42MzZmNzgyZTYzNmY2ZEVRRE4AAAAaAAAABDIwMTIAAAAONjM2Zjc4MmU2" +
            "ZTY1NzRFUUROAAAAKgAAAAQyMDEyAAAAHjYzNmY3ODYyNzU3MzY5NmU2NTczNzMy" +
            "ZTYzNmY2ZEVRRE4AAAAyAAAABDIwMjIAAAAmNmQ3OTZlNmY3Mjc0NmY2ZTYxNjM2" +
            "MzZmNzU2ZTc0MmU2MzZmNmRFUUROAAAAIAAAAAQyMDIyAAAAFDZlNmY3Mjc0NmY2" +
            "ZTJlNjM2ZjZkRVFETgAAACIAAAAEMjAzMgAAABY3NjY1NzI2OTdhNmY2ZTJlNjM2" +
            "ZjZkRVFETgAAACIAAAAEMjAzMgAAABY3NjY1NzI2OTdhNmY2ZTJlNmU2NTc0RVFE" +
            "TgAAACIAAAAEMjA0MgAAABY2YzZmNjc2ZDY1Njk2ZTJlNjM2ZjZkRVFETgAAABwA" +
            "AAAEMjA0MgAAABA2YzZmNjc2ZDY1MmU2OTZlRVFETgAAACIAAAAEMjA1MgAAABY3" +
            "MjYxNmI3NTc0NjU2ZTJlNjM2ZjZkRVFETgAAABoAAAAEMjA1MgAAAA42Mjc1Nzky" +
            "ZTYzNmY2ZEVRRE4AAAAkAAAABDIwNjIAAAAYNzM2OTcyNjk3NTczNzg2ZDJlNjM2" +
            "ZjZkRVFETgAAACAAAAAEMjA2MgAAABQ3MzY5NzI2OTc1NzMyZTYzNmY2ZEVRRE4A" +
            "AAAYAAAABDIwNzIAAAAMNjU2MTJlNjM2ZjZkRVFETgAAACAAAAAEMjA3MgAAABQ2" +
            "ZjcyNjk2NzY5NmUyZTYzNmY2ZEVRRE4AAAAmAAAABDIwNzIAAAAaNzA2YzYxNzkz" +
            "NDY2NzI2NTY1MmU2MzZmNmRFUUROAAAANAAAAAQyMDcyAAAAKDc0Njk2MjY1NzI2" +
            "OTc1NmQ2MTZjNmM2OTYxNmU2MzY1MmU2MzZmNmRVUlVMAAAAKAAAABo2NzZmNmY2" +
            "NzZjNjUyZTYzNmY2ZDJmNjEyZgAAAAEwAAAAATBVUlVMAAAAJAAAABY2YzZmNjc2" +
            "ZDY1Njk2ZTJlNjM2ZjZkAAAAATEAAAABMFVSVUwAAAA6AAAALDczNjk3NDY1NzMy" +
            "ZTY3NmY2ZjY3NmM2NTJlNjM2ZjZkMmY3MzY5NzQ2NTJmAAAAATAAAAABMFVSVUwA" +
            "AAAiAAAAFDc3NjU2NTYyNmM3OTJlNjM2ZjZkAAAAATEAAAABMFVSVUwAAAAcAAAA" +
            "Djc3Njk3ODJlNjM2ZjZkAAAAATEAAAABMFVSVUwAAAAeAAAAEDc3NjU2MjczMmU2" +
            "MzZmNmQAAAABMQAAAAEwVVJVTAAAACgAAAAaNjg2ZjZkNjU3Mzc0NjU2MTY0MmU2" +
            "MzZmNmQAAAABMQAAAAEwVVJVTAAAACgAAAAaNzc2ZjcyNjQ3MDcyNjU3MzczMmU2" +
            "MzZmNmQAAAABMQAAAAEwVVJVTAAAACAAAAASNmE2OTZkNjQ2ZjJlNjM2ZjZkAAAA" +
            "ATEAAAABMFVSVUwAAAAoAAAAGjc3NjU2MjczNzQ2MTcyNzQ3MzJlNjM2ZjZkAAAA" +
            "ATEAAAABMFVSVUwAAAAoAAAAGjczNmU2MTcwNzA2MTY3NjU3MzJlNjM2ZjZkAAAA" +
            "ATEAAAABMFVSVUwAAAAsAAAAHjYzNmM2Zjc1NjQ2MTYzNjM2NTczNzMyZTZlNjU3" +
            "NAAAAAExAAAAATBVUlVMAAAAJAAAABY3NzY1NjI2ZTZmNjQ2NTJlNjM2ZjZkAAAA" +
            "ATEAAAABMFVSVUwAAAAsAAAAHjZmNmU2ZDY5NjM3MjZmNzM2ZjY2NzQyZTYzNmY2" +
            "ZAAAAAExAAAAATBVUlVMAAAAKAAAABo2ODY1NzI2ZjZiNzU2MTcwNzAyZTYzNmY2" +
            "ZAAAAAExAAAAATBVUlVMAAAAGgAAAAw2ZTZmNzYyZTcyNzUAAAABMQAAAAEwRU5E" +
            "TQAAAAJPSw==";

        public static readonly byte[] Blob = BlobBase64.Decode64();
    }
}
