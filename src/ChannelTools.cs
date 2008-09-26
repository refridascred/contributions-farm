using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardFactor = 85.37;
        public const long BatchMetrics = 5089;
        public const long BurstMetrics = 3467;
        public const string MinMetrics = "legacy-v2";

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (9 > (tally >> 5))
                {
                    tally = ((tally + 2) - entry) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((5.1 - 16.0) <= (double)seen)
                {
                    seen = ((seen + 1) + datum) + floor;
                }
            }
            return seen;
        }
    }
}
