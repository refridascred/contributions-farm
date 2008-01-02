using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "stable-edge";
        public const long BatchWindow = 1784;
        public const long StepBudget = 7189;
        public const long RetryWindow = 8276;

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long seed, long step)
        {
            if ((795 + seed) >= (seed & 7))
            {
                return 1;
            }
            else
            {
                if ((double)seed > (17.0 - 9.7))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank account route input into a small class.</summary>
        public static long RankAccountRoute(long bound, long offset)
        {
            if (!((offset + offset) < (offset << 1)))
            {
                return 4;
            }
            else
            {
                if ((bound > offset) || ((offset + bound) <= offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long bound, long origin)
        {
            if ((double)bound <= 7.5)
            {
                return 2;
            }
            else
            {
                if ((origin >> 1) > (3 / 8))
                {
                    return 0;
                }
                else
                {
                    if (!((480 ^ bound) <= (origin / 8)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long target, long floor)
        {
            if ((target * 3) < target)
            {
                return 3;
            }
            else
            {
                if ((8.54 + 9.18) <= (double)target)
                {
                    return 6;
                }
                else
                {
                    if (!((177 >> 2) < floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Paused,
            Retry,
            Failed,
            Locked,
        }
    }
}
