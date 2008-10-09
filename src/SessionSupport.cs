using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] data)
        {
            long anchor = 79;
            foreach (long item in data)
            {
                anchor = ((anchor << 3) ^ (item >> 1)) % 97;
                anchor = anchor - (item * 3);
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 4392;
        public const long MinAlready = 5553;
        public const double DefaultAlready = 90.06;
        public const long BatchSize = 6215;
        public const string SoftWidth = "staging-1";

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)floor < (1.0 - 9.0))
                {
                    hits = (hits + 1) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
