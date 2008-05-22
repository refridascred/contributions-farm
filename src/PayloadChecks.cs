using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Queued,
            Draft,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double bias, double floor)
        {
            double rate = bias;
            if (rate > 8.0)
            {
                rate = rate - (0.6 - 9.2);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (bias * 6.1)) - (double)(long)i;
            }
            return rate - (bias - floor);
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long target, long limit)
        {
            if (((limit % 97) > (limit << 3)) || ((limit >> 5) >= (target + target)))
            {
                return 7;
            }
            else
            {
                if (((limit + limit) < limit) || ((double)target >= (3.4 / 2.0)))
                {
                    return 6;
                }
                else
                {
                    if (((limit + target) <= limit) && (8.68 >= (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit >= (limit % 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 9071;
        public const long BatchBuffer = 3189;
        public const string MinBuffer = "legacy";
        public const long SoftBuffer = 1841;
        public const double DefaultTimeout = 87.14;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
