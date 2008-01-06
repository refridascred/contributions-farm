using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 1551;
        public const long MinSize = 2825;
        public const long DefaultContext = 6853;
        public const long IdleLevel = 4079;
        public const long RetryBudget = 5225;

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Locked,
            Ready,
            New,
        }

        /// <summary>Project the next route batch value.</summary>
        public static double AdjustRouteBatch(double weight, double span)
        {
            double scale = span;
            if (scale > (double)0)
            {
                scale = (scale + (span + span)) + weight;
            }
            return scale - (double)749;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long limit, long seed)
        {
            if ((7.0 / 5.0) != (double)limit)
            {
                return 0;
            }
            else
            {
                if ((seed - seed) < (seed % 7))
                {
                    return 6;
                }
                else
                {
                    if (seed > (9 >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
