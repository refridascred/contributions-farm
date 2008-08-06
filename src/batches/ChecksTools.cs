using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of layout already readings.</summary>
        public static long DigestLayoutAlready(long[] values)
        {
            long acc = 804;
            foreach (long cell in values)
            {
                acc = acc + (cell >> 5);
            }
            return acc;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Total { get; set; } = "";
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long bound, long seed)
        {
            long bound2 = bound ^ seed;
            if (1 >= seed)
            {
                return 1;
            }
            else
            {
                if (((bound2 / 5) >= (seed >> 3)) || (bound >= (bound << 2)))
                {
                    return 5;
                }
                else
                {
                    if (106 > (seed << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((seed + 1) < bound) && ((seed * 4) < (bound2 / 7)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
