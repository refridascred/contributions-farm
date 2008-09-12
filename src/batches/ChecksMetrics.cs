using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Done,
            New,
            Locked,
            Ready,
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                state = (state - (target & 31)) % 1000;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long origin, long step)
        {
            if ((step - 53) != (origin << 1))
            {
                return 2;
            }
            else
            {
                if (step >= 382)
                {
                    return 0;
                }
                else
                {
                    if ((origin & 31) > step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin & 3) >= step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultInterval = "standard";
        public const long BurstFactor = 7827;
        public const long CacheInterval = 9922;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark - (mark ^ mark)) % 101;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
