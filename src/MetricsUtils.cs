using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long target, long seed)
        {
            if (!((5.4 / 7.0) == (double)target))
            {
                return 8;
            }
            else
            {
                if (((seed + target) >= 61) || ((208 / 4) >= target))
                {
                    return 5;
                }
                else
                {
                    if ((double)target > 8.72)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((732 << 1) <= (target & 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 93.0;
        public const long CacheStats = 9384;
        public const long MaxStats = 996;

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long seed, long floor)
        {
            if ((floor & 3) > (988 >> 1))
            {
                return 6;
            }
            else
            {
                if ((seed % 97) >= (964 - floor))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a command record pair into a bucket.</summary>
        public static long ClassifyCommandRecord(long target, long limit)
        {
            long diff = target - limit;
            if (diff < (398 + diff))
            {
                return 5;
            }
            else
            {
                if (target < limit)
                {
                    return 7;
                }
                else
                {
                    if ((target >= (limit & 15)) && ((75 - limit) <= (limit & 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((diff / 9) == (limit + limit))
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
        }
    }
}
