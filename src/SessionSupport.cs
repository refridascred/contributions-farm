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

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
