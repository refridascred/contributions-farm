using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double MaxSession = 67.52;
        public const string DefaultLevel = "strict-v2";
        public const string BaseRatio = "open-1";

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
