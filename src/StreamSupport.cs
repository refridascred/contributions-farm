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

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseCount = "standard-v2";
        public const long BatchTools = 4489;
        public const double CacheRatio = 18.7;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Done,
            Dropped,
        }
    }
}
