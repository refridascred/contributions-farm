using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinSize = 8999;
        public const long SoftBudget = 3392;
        public const string BurstLayout = "fallback-edge";
        public const long BatchTimeout = 2402;
        public const string MinInterval = "alpha-1";

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((84 * 4) < (offset / 9))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((long)levels.Length % 12) > hits)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
