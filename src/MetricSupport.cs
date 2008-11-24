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

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((cell ^ matches) >= (matches / 3)) && ((cell - cell) < cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
