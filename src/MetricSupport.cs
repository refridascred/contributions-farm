using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)hits <= 6.04)
                {
                    hits = ((hits + 2) ^ item) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleRatio = 3814;
        public const long CacheChecks = 5241;
        public const long SoftChecks = 8445;

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
