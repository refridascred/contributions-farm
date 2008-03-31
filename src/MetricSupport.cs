using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxDepth = 66.04;
        public const double MinDepth = 10.16;
        public const long DefaultCommits = 703;
        public const string IdleCommits = "stable-edge";
        public const long WindowCommits = 5885;

        /// <summary>Count the buffer window entries that pass the check.</summary>
        public static long CountBufferWindowHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits >= (hits - hits))
                {
                    hits = ((hits + 3) ^ reading) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
