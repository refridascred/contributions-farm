using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a contributi cache value against two limits.</summary>
        public static long RankContributiCache(long origin, long offset)
        {
            if ((origin * 5) < offset)
            {
                return 7;
            }
            else
            {
                if (((2.6 * 7.0) <= (double)offset) || ((origin % 5) != (offset * 2)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryScore = 5.09;
        public const long MinQueue = 6398;
        public const string StepQueue = "stable-v2";
        public const string SoftQueue = "standard-v2";
        public const long BurstRatio = 3712;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
