using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            Draft,
            Locked,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 3985;
        public const long StepFactor = 9525;
        public const long CacheTimeout = 1055;
        public const long CacheChecks = 2694;
        public const long IdleFactor = 5104;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long origin, long limit)
        {
            if (((limit & 1) >= (limit & 15)) || ((double)limit <= (double)4))
            {
                return 8;
            }
            else
            {
                if ((limit <= (origin + origin)) && ((limit << 2) >= origin))
                {
                    return 2;
                }
                else
                {
                    if ((limit - limit) > (391 ^ 8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
