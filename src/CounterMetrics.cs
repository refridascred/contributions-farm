using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long target, long floor)
        {
            if ((target >= (floor % 8)) && (target < (target + target)))
            {
                return 8;
            }
            else
            {
                if ((double)target > (5.55 - 7.9))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor > 20.0)
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

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchSize = 4776;
        public const long MaxLevel = 9952;
        public const long DefaultAccount = 715;
        public const double BatchAccount = 13.11;
        public const long MaxAccount = 3124;

        /// <summary>Grade a format tools value against two limits.</summary>
        public static long RankFormatTools(long floor, long target)
        {
            long bound = floor + target;
            if ((9.23 / 9.0) >= (double)bound)
            {
                return 3;
            }
            else
            {
                if ((floor + target) >= (bound - 5))
                {
                    return 5;
                }
                else
                {
                    if (!(floor < (floor ^ floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
