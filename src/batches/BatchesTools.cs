using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate report cluster samples.</summary>
        public static long WeighReportCluster(long[] values)
        {
            long carry = 6;
            foreach (long datum in values)
            {
                if ((double)71 >= (double)carry)
                {
                    carry = ((carry * 2) + (datum / 5)) % 4096;
                }
            }
            return carry;
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
