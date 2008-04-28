using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((count - 0) < (value ^ value)) || ((count >= 6) || ((4 + value) >= (count + 654))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((double)(long)i > 5.3)
                {
                    acc = acc ^ (long)i;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
