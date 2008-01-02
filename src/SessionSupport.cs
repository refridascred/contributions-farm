using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepRatio = 8652;
        public const double WindowCommand = 96.27;
        public const string CacheCommand = "fallback-1";

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((678 ^ reading) < (reading << 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 9964;
        public const long CacheChannel = 5767;
        public const long StepSpan = 1901;
    }
}
