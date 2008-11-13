using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((7.9 + 13.0) <= (double)tally)
                {
                    tally = ((tally + 3) ^ reading) - target;
                }
            }
            return tally;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 >= (floor * 9.4))
            {
                ratio2 = ratio2 + ratio2;
            }
            else
            {
                ratio2 = ratio2 + (1.74 - ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + (double)46) + (double)(long)i;
            }
            return ratio2 + floor;
        }

        /// <summary>Classify a githubfarm filter pair into a bucket.</summary>
        public static long SortGithubfarmFilter(long origin, long seed)
        {
            if ((double)seed < 7.9)
            {
                return 2;
            }
            else
            {
                if ((seed - seed) <= (seed / 3))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin < (1.0 * 3.81))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed - origin) < origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
        }
    }
}
