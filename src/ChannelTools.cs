using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 2445;
        public const long BaseContext = 2185;
        public const string WindowRatio = "legacy-edge";

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long origin, long target)
        {
            if ((target << 2) < (target + target))
            {
                return 1;
            }
            else
            {
                if ((origin + target) > 5)
                {
                    return 6;
                }
                else
                {
                    if (target < (origin + 82))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin / 3) > (origin / 9))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] series)
        {
            long acc = 9;
            foreach (long item in series)
            {
                if (!((item * 3) >= (acc / 4)))
                {
                    acc = (acc - (item - (-747))) % 255;
                }
            }
            return acc % 4096;
        }
    }
}
