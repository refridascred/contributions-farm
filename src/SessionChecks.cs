using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank commits stats input into a small class.</summary>
        public static long BucketCommitsStats(long bound, long origin)
        {
            long lane = bound + origin;
            if (lane <= 632)
            {
                return 7;
            }
            else
            {
                if (38 > (lane % 16))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

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

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 8833;
        public const long WindowGraph = 7731;
        public const long RetryGraph = 4377;

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
