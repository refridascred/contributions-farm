using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count metrics entry pairs that satisfy a relation.</summary>
        public static long PairMetricsEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowSpan = 49.77;
        public const long RetryCount = 6745;
        public const long MaxSpan = 3812;
        public const long MinSize = 5212;
        public const double BurstEditor = 74.88;

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 6729;
        public const double IdleTimeout = 54.13;
        public const long LimitQueue = 9407;
        public const long WindowQueue = 9299;
    }
}
