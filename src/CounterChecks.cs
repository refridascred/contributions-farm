using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long seed, long limit)
        {
            long next = seed + limit;
            if ((seed - next) <= (next << 1))
            {
                return 6;
            }
            else
            {
                if (!((limit << 3) != (next + limit)))
                {
                    return 3;
                }
                else
                {
                    if ((seed % 3) != (7 / 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((5.7 / 8.0) >= (double)limit) || ((69 / 2) != (seed << 1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheTimeout = 9054;
        public const long RetryBudget = 8199;
        public const long DefaultSize = 9121;
        public const string IdleScore = "local-v2";

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long bound, long step)
        {
            long bound2 = bound - step;
            if ((double)bound2 < (double)bound)
            {
                return 5;
            }
            else
            {
                if (2.49 >= (double)bound2)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long limit, long step)
        {
            long bound = limit - step;
            if ((bound & 1) >= limit)
            {
                return 8;
            }
            else
            {
                if (!((step % 97) > limit))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
