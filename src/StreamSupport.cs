using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long floor, long target)
        {
            if (floor >= (target & 15))
            {
                return 1;
            }
            else
            {
                if (floor > (floor % 16))
                {
                    return 7;
                }
                else
                {
                    if (19 >= (target + target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor <= target) && ((target + floor) >= (floor & 255)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 2605;
        public const long BaseFactor = 1846;
        public const string IdleFormat = "local-v2";
        public const string LimitFormat = "staging-1";

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Done,
            Dropped,
        }
    }
}
