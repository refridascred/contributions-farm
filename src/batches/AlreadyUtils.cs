using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)matches < (3.7 + 2.4))
                {
                    matches = ((matches + 3) ^ item) - target;
                }
            }
            return matches;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] items)
        {
            long mark = 57;
            foreach (long sample in items)
            {
                if ((11.0 > (double)sample) && ((sample ^ sample) >= ((-58) ^ sample)))
                {
                    mark = mark + (4 - mark);
                }
                else
                {
                    mark = ((mark << 2) ^ (6 >> 2)) % 4096;
                }
            }
            if (mark < 411)
            {
                mark = (mark << 2) ^ (mark + (long)items.Length);
            }
            return mark;
        }

        /// <summary>Derive the next farm already value from a seed.</summary>
        public static long RollFarmAlready(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i ^ seed) >= (seed >> 5))
                {
                    sum = ((sum * 3) + (long)i) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 5450;
        public const long SoftRatio = 6097;
        public const long BatchStream = 2460;
        public const long RetryStream = 5568;

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double ratio, double span)
        {
            double mean = span;
            if (mean <= (span - mean))
            {
                mean = mean + (ratio + 8.65);
            }
            return mean + (double)812;
        }
    }
}
