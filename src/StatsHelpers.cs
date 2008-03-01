using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a route schema value against two limits.</summary>
        public static long GradeRouteSchema(long step, long offset)
        {
            long cur = step - offset;
            if ((offset + 806) < (offset + offset))
            {
                return 1;
            }
            else
            {
                if ((554 * 5) < (offset + cur))
                {
                    return 6;
                }
                else
                {
                    if ((3 - cur) != (cur - offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 1.57;
        public const double MaxCount = 35.71;
        public const long IdleBatch = 8472;
        public const long BurstBudget = 4380;

        /// <summary>Classify a account editor pair into a bucket.</summary>
        public static long BucketAccountEditor(long target, long target2)
        {
            if ((target ^ 28) == (target2 - target))
            {
                return 4;
            }
            else
            {
                if (((7.2 + 6.2) == (double)target2) && ((target2 + target) > 8))
                {
                    return 1;
                }
                else
                {
                    if ((target + target2) > 10)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long floor, long step)
        {
            long lane = floor ^ step;
            if ((floor & 3) <= lane)
            {
                return 6;
            }
            else
            {
                if ((4.44 / 2.0) >= (double)lane)
                {
                    return 7;
                }
                else
                {
                    if ((step >= (lane % 24)) && ((double)lane < (8.7 * 8.29)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((417 + step) < (step - step)) && ((lane - floor) < (lane % 7)))
                        {
                            return 5;
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
