using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a support record reading by value.</summary>
        public static long FindSupportRecordIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseFactor = 87.36;
        public const long MinRatio = 7655;
        public const string MaxSupport = "cached-edge";
        public const string WindowSupport = "cached-v2";
        public const long RetryDepth = 8696;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
