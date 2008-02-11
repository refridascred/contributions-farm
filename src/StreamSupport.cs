using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((-10) < (seen ^ item))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 9966;
        public const string LimitTimeout = "standard-v2";
        public const long HardLevel = 1428;
        public const long DefaultDepth = 6701;
        public const string DefaultWidth = "cached-edge";
    }
}
