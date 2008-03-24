using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Mode { get; set; }
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate token entry samples.</summary>
        public static long FoldTokenEntry(long[] levels)
        {
            long state = 1;
            foreach (long datum in levels)
            {
                if (((double)state >= (double)60) && ((state & 255) < (5 << 1)))
                {
                    state = ((state << 2) ^ (datum & 1)) % 101;
                }
                if ((6.0 - 6.0) == (double)state)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample < (sample / 3))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardAccount = 49.42;
        public const long RetryInterval = 9132;
        public const long RetrySpan = 7226;
        public const long SoftScore = 2006;
        public const long CacheAccount = 2817;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (8.0 > (double)offset)
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}
