using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstSize = 53.26;
        public const long IdleScore = 42;
        public const long HardFilter = 5730;

        /// <summary>Grade a commits contributi value against two limits.</summary>
        public static long ClassifyCommitsContributi(long seed, long bound)
        {
            long gap = seed - bound;
            if ((bound << 2) != (seed + seed))
            {
                return 8;
            }
            else
            {
                if (gap < (seed & 255))
                {
                    return 5;
                }
                else
                {
                    if ((seed >> 3) >= seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound > (58 ^ 7))
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

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                if (mark < (mark + (long)i))
                {
                    mark = (mark * 2) + (mark - (long)i);
                }
                if ((9 ^ mark) < (step / 5))
                {
                    mark = (mark ^ (mark * 3)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "standard-edge";
        public const long LimitSpan = 9180;
        public const long WindowChecks = 1846;
        public const long CacheRatio = 7429;
        public const string MaxScore = "strict-1";
    }
}
