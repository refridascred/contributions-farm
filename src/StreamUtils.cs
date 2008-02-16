using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - (mark + mark)) % 65521;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardFactor = 3393;
        public const long HardInterval = 2469;
        public const long BaseLevel = 3849;

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftSize = "staging-v2";
        public const long RetryBudget = 6017;
        public const double DefaultSize = 4.82;
        public const long MaxEntry = 6523;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Ready,
            Synced,
            Closed,
            Stale,
        }
    }
}
