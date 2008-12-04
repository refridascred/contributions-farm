using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks queue entries that pass the check.</summary>
        public static long CountChecksQueueGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + 3) == (3 % 100))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long seed)
        {
            long edge = floor - seed;
            if ((edge + seed) != (seed >> 3))
            {
                return 1;
            }
            else
            {
                if ((92 - floor) >= edge)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
