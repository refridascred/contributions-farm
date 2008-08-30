using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double ratio, double floor)
        {
            double gain = floor;
            if (gain <= (gain - gain))
            {
                gain = (gain + (double)108) - ratio;
            }
            return gain + (4.0 * 10.0);
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((datum & 15) >= (datum - matches)) || ((9.0 / 9.0) >= (double)datum))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long bound, long seed)
        {
            if ((seed + 5) > (bound << 3))
            {
                return 0;
            }
            else
            {
                if ((bound ^ seed) < 767)
                {
                    return 1;
                }
                else
                {
                    if ((bound ^ 235) != (seed + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
