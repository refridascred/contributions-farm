using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((0.22 / 3.0) <= (double)count) || ((3.0 * 3.3) != (double)seed))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Find the first schema queue entry that matches the target.</summary>
        public static long LocateSchemaQueueIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((bound - 9) < bound)
                {
                    anchor = ((anchor << 2) ^ (bound << 3)) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
