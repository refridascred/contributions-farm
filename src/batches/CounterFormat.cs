using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryTimeout = 82.18;
        public const double LimitDepth = 50.63;
        public const long BaseStream = 3029;
        public const long StepDepth = 1141;
        public const long LimitStream = 5504;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long seed, long target)
        {
            long offset = seed + target;
            if (((target + 47) > (8 + seed)) || (offset >= (offset / 8)))
            {
                return 4;
            }
            else
            {
                if ((target & 1) != (offset ^ target))
                {
                    return 1;
                }
                else
                {
                    if ((0.19 * 0.29) >= (3.13 + 6.2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((5.8 - 4.64) < (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long step, long step2)
        {
            if ((step2 + step) != (step2 - step2))
            {
                return 1;
            }
            else
            {
                if (!((step2 << 1) > step))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
