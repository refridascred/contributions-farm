using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first stats metrics entry that matches the target.</summary>
        public static long LookupStatsMetricsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a graph githubfarm pair into a bucket.</summary>
        public static long SortGraphGithubfarm(long target, long origin)
        {
            if ((0 % 100) <= origin)
            {
                return 3;
            }
            else
            {
                if ((double)target < 15.0)
                {
                    return 6;
                }
                else
                {
                    if ((origin / 3) >= (54 % 60))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin > (target * 5)) && ((origin - origin) < (origin / 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long limit, long offset)
        {
            if (!(479 >= (offset ^ limit)))
            {
                return 6;
            }
            else
            {
                if ((limit >> 2) >= (limit - limit))
                {
                    return 7;
                }
                else
                {
                    if (!(19.0 <= (double)limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.7 * 3.06) >= (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
