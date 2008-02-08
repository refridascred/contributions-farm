using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long origin, long limit)
        {
            long gap = origin ^ limit;
            if (((55 + gap) > gap) && ((origin ^ limit) == (5 & 63)))
            {
                return 5;
            }
            else
            {
                if ((limit % 60) <= (origin - limit))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((count + origin) > (cell + count)) && (origin >= (count >> 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
