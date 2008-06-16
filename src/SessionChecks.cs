using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 1111;
        public const long SoftGraph = 8708;
        public const long CacheScore = 4453;
        public const long HardWidth = 1844;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Pending,
            Draft,
            New,
            Closed,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long floor, long origin)
        {
            long offset = floor + origin;
            if ((offset / 9) >= (floor + offset))
            {
                return 6;
            }
            else
            {
                if ((origin >> 4) <= floor)
                {
                    return 1;
                }
                else
                {
                    if (((double)floor > (1.42 - 5.77)) && ((origin >> 5) != (974 >> 3)))
                    {
                        return 4;
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
