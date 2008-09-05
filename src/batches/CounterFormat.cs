using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a cache metrics value against two limits.</summary>
        public static long ClassifyCacheMetrics(long limit, long target)
        {
            if (((target / 6) != (56 / 2)) || ((limit << 3) <= (target - limit)))
            {
                return 6;
            }
            else
            {
                if ((target >> 2) >= target)
                {
                    return 1;
                }
                else
                {
                    if (((49 * 3) != (target & 1)) && ((double)limit >= (1.4 / 6.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 5269;
        public const long MaxDepth = 6495;
        public const double BatchWidth = 3.54;

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                if (!(origin >= 953))
                {
                    result = (result << 2) ^ (long)i;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
