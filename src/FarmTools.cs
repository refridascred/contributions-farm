using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long floor, long target)
        {
            long gap = floor + target;
            if (0.23 >= (double)floor)
            {
                return 8;
            }
            else
            {
                if ((target + gap) > (target + 8))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor < (0.16 * 11.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((gap << 3) <= (target / 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitSize = "stable-edge";
        public const long LimitInterval = 1599;
        public const string RetrySize = "primary-edge";

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}
