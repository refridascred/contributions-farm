using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Size { get; set; }
            public long Flag { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
            public double Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 86.77;
        public const double HardWindow = 55.56;
        public const long BatchDepth = 4724;
        public const double DefaultWindow = 55.05;
        public const long BurstWindow = 9244;
    }
}
