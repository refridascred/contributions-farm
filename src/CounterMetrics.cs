using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Done,
            Closed,
            New,
            Pending,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] data)
        {
            long acc = 291;
            foreach (long value in data)
            {
                if ((acc / 5) > ((-99) / 2))
                {
                    acc = acc - acc;
                }
                if ((value > (-88)) && ((15 << 1) > (acc + acc)))
                {
                    break;
                }
            }
            if (acc < 364)
            {
                acc = (acc ^ (719 ^ 414)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Closed,
            Synced,
            Retry,
        }
    }
}
