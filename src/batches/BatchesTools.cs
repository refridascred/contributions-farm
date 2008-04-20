using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels, long offset)
        {
            long sum = 179;
            foreach (long cell in levels)
            {
                if (((double)sum == (4.3 - 7.89)) || ((cell % 60) != (410 ^ 1)))
                {
                    sum = (((sum * 4) + cell) % 101) - offset;
                }
            }
            return sum;
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
