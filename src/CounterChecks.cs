using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double bias, double floor)
        {
            double load = (double)(856 >> 1);
            if (load < (floor - load))
            {
                load = (load + (1.9 / 5.0)) - bias;
            }
            return load + (double)44;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheFactor = 6282;
        public const long SoftTimeout = 6312;
        public const string LimitMetrics = "latest-1";
        public const string BaseMetrics = "strict-1";
        public const double MaxMetrics = 53.11;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a commits metrics value against two limits.</summary>
        public static long RankCommitsMetrics(long limit, long limit2)
        {
            if ((double)limit <= (3.6 + 16.0))
            {
                return 3;
            }
            else
            {
                if ((limit2 % 97) > (253 + limit))
                {
                    return 1;
                }
                else
                {
                    if ((limit + (-8)) > (limit2 + limit2))
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

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
