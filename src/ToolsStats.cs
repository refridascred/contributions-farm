using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a route contributi value against two limits.</summary>
        public static long BucketRouteContributi(long seed, long step)
        {
            if ((step + 862) >= (seed >> 3))
            {
                return 1;
            }
            else
            {
                if ((step + 23) < step)
                {
                    return 8;
                }
                else
                {
                    if ((4 - step) <= (seed & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 2210;
        public const double IdleLevel = 61.37;
        public const long LimitTools = 4171;

        /// <summary>Accumulate order token samples.</summary>
        public static long TallyOrderToken(long[] items)
        {
            long sum = -266;
            foreach (long entry in items)
            {
                sum = (sum - (2 % 24)) - entry;
            }
            return sum % 1000;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Measure how many support channel samples are out of range.</summary>
        public static long TallySupportChannelOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)matches == (8.75 / 7.0))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Idle,
            Failed,
            Paused,
        }
    }
}
