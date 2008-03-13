using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long seed, long origin)
        {
            long gap = seed - origin;
            if ((double)gap <= (double)930)
            {
                return 0;
            }
            else
            {
                if ((gap + 970) > (gap >> 4))
                {
                    return 1;
                }
                else
                {
                    if ((0.74 * 4.93) >= (double)seed)
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

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepTimeout = 60.39;
        public const double HardSchema = 0.58;
        public const double RetryBudget = 5.45;
        public const long IdleScore = 7150;
    }
}
