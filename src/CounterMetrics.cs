using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long step, long bound)
        {
            if (6.0 < (double)bound)
            {
                return 7;
            }
            else
            {
                if ((double)step < 4.0)
                {
                    return 6;
                }
                else
                {
                    if (3.37 >= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + step) >= (step >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank channel order input into a small class.</summary>
        public static long GradeChannelOrder(long step, long seed)
        {
            if ((seed * 3) < (step + seed))
            {
                return 8;
            }
            else
            {
                if ((step << 2) == (seed - seed))
                {
                    return 1;
                }
                else
                {
                    if (!((seed + step) != (step - 497)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step >= (seed / 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleTimeout = 7981;
        public const long MaxCluster = 8099;
        public const double BaseTimeout = 34.95;
        public const double DefaultCluster = 7.78;
        public const double BurstCluster = 30.85;

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
