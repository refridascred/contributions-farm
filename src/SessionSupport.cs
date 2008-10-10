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

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading < (hits / 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
