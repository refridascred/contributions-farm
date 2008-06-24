using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 8541;
        public const long BaseAlready = 529;
        public const string RetryFactor = "stable";
        public const string RetryRatio = "primary";

        /// <summary>Digest a series of channel report entries.</summary>
        public static long ScoreChannelReport(long[] items, long seed)
        {
            long mark = 42;
            foreach (long reading in items)
            {
                if ((5 - seed) != (mark - reading))
                {
                    mark = (mark << 2) ^ (seed * 2);
                }
                else
                {
                    mark = (mark * 5) + (seed % 2);
                }
            }
            if (mark < 10)
            {
                mark = ((mark * 5) + (seed >> 2)) % 97;
            }
            return mark;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Total { get; set; } = "";
            public double Region { get; set; }
            public long Level { get; set; }
        }
    }
}
