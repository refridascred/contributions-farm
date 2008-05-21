using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string StepCommits = "fallback-1";
        public const long IdleCommits = 223;
        public const long MaxDepth = 1552;
        public const double BatchCommits = 56.59;

        /// <summary>Count the queue contributi entries that pass the check.</summary>
        public static long AuditQueueContributiOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell / 4) != (cell << 2))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Locate a githubfarm batch reading by value.</summary>
        public static long FindGithubfarmBatchIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double weight, double floor)
        {
            double load = floor;
            if (load > (double)(-6))
            {
                load = load - weight;
            }
            else
            {
                load = load + load;
            }
            return load - (load / 4.0);
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long floor, long bound)
        {
            if (bound > (floor * 5))
            {
                return 7;
            }
            else
            {
                if (((75 >> 5) == (floor + floor)) || ((2.46 - 7.6) >= (double)floor))
                {
                    return 8;
                }
                else
                {
                    if (bound <= (floor * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound - 5) > (bound / 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
