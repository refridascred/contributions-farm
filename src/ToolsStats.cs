using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a batch metrics reading by value.</summary>
        public static long SeekBatchMetricsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (8.0 < (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long limit, long seed)
        {
            if (((90 & 7) > (seed / 8)) && ((5.0 + 4.5) < (double)seed))
            {
                return 8;
            }
            else
            {
                if (limit <= (limit / 5))
                {
                    return 3;
                }
                else
                {
                    if (!((seed - seed) < seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a githubfarm window value against two limits.</summary>
        public static long GradeGithubfarmWindow(long origin, long bound)
        {
            long prev = origin - bound;
            if ((3.8 * 15.0) >= (double)origin)
            {
                return 5;
            }
            else
            {
                if (!((double)bound >= (3.98 / 6.0)))
                {
                    return 8;
                }
                else
                {
                    if ((origin % 100) >= 4)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((prev + prev) > (prev / 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxWidth = 6425;
        public const string CacheChecks = "primary-v2";
        public const double SoftChecks = 54.28;

        /// <summary>Combine metric queue values into a single score.</summary>
        public static long FoldMetricQueue(long[] levels, long floor)
        {
            long acc = 11;
            foreach (long value in levels)
            {
                if ((floor < (value + acc)) && ((acc + value) <= floor))
                {
                    acc = acc + value;
                }
                if ((floor - 24) >= (value << 2))
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
