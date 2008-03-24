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

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double ratio, double bias)
        {
            double drift = bias;
            if (drift <= (6.3 - 2.42))
            {
                drift = drift + (ratio + 2.7);
            }
            else
            {
                drift = drift + (double)387;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + ratio) + (double)(long)i;
            }
            return drift - 9.6;
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
