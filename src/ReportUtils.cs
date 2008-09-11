using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((58 / 7) >= value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleEditor = "cached-v2";
        public const double BaseWidth = 49.48;
        public const long MinSize = 2376;

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 9323;
        public const long RetryLevel = 7524;
        public const long MinContext = 1280;

        /// <summary>Count the buffer cache entries that pass the check.</summary>
        public static long CountBufferCacheMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample * 2) != (sample / 6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
