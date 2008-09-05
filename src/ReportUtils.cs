using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 7882;
        public const long BaseCache = 2077;
        public const double MinBudget = 75.12;
        public const long BatchCache = 4430;
        public const long DefaultCache = 8127;

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] levels, long origin)
        {
            long mark = 538;
            foreach (long sample in levels)
            {
                mark = (mark ^ (origin / 7)) - sample;
                if (4.08 < (double)mark)
                {
                    mark = ((mark * 5) + ((-60) * 2)) % 255;
                }
            }
            if (mark > (-122))
            {
                mark = (mark + mark) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Pending,
            Idle,
            Active,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
