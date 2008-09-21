using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Idle,
            Done,
            Failed,
            Locked,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long origin, long origin2)
        {
            long offset = origin - origin2;
            if (!((origin + origin) != (offset << 1)))
            {
                return 7;
            }
            else
            {
                if (((origin / 3) <= offset) || (origin > (origin << 2)))
                {
                    return 3;
                }
                else
                {
                    if ((origin / 8) == (origin ^ 509))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset / 2) <= (offset & 15))
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

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstScore = 9267;
        public const string MinTimeout = "primary-v2";
        public const long IdleCommand = 395;
    }
}
