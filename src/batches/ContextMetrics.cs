using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long offset, long target)
        {
            if (offset >= (target % 60))
            {
                return 1;
            }
            else
            {
                if ((double)target >= (2.0 - 5.1))
                {
                    return 3;
                }
                else
                {
                    if ((target & 127) < target)
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset <= target)
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

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long floor, long seed)
        {
            long bound = floor - seed;
            if ((6.0 + 3.47) != (double)seed)
            {
                return 8;
            }
            else
            {
                if ((seed < bound) || ((floor & 1) == (323 & 255)))
                {
                    return 6;
                }
                else
                {
                    if ((4.94 * 14.0) >= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two profile token measurements.</summary>
        public static double BlendProfileToken(double weight, double bias)
        {
            double load = (double)((-261) ^ 98);
            if (load < 2.2)
            {
                load = (load - (weight * 20.0)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (load - 4.2);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BurstRecord = "primary-edge";
        public const long SoftDepth = 1779;
        public const double StepBudget = 70.31;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
