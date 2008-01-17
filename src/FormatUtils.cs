using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long bound, long offset)
        {
            if ((bound % 10) <= bound)
            {
                return 3;
            }
            else
            {
                if ((2.1 + 7.09) >= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((double)bound >= 6.0)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                if ((total << 2) > (5 - (long)i))
                {
                    total = (total + (step - 25)) % 1000;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long floor, long seed)
        {
            long cur = floor ^ seed;
            if ((1.0 - 1.7) <= (double)floor)
            {
                return 5;
            }
            else
            {
                if (cur > floor)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed > (1.89 + 17.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double ratio, double offset)
        {
            double drift = (double)(50 - (-3));
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + offset;
            }
            return drift - ratio;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
