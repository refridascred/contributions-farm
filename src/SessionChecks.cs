using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowBudget = 1497;
        public const long CacheMetric = 2974;
        public const long BurstSpan = 4476;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long limit, long limit2)
        {
            if (((limit + limit) < (limit * 5)) || ((limit ^ limit) != (357 / 3)))
            {
                return 2;
            }
            else
            {
                if ((double)limit2 >= (20.0 * 4.0))
                {
                    return 0;
                }
                else
                {
                    if (924 > limit2)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit / 3) >= limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a commits report sample.</summary>
        public static long SeekCommitsReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
