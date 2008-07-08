using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double weight, double offset)
        {
            double ratio = 18.0;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (double)(long)i) + weight) + offset;
            }
            return ratio + (double)65;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long offset, long floor)
        {
            if ((offset - offset) > (offset - 160))
            {
                return 1;
            }
            else
            {
                if ((offset + 88) < floor)
                {
                    return 6;
                }
                else
                {
                    if ((floor % 24) < (floor % 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading / 6) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
