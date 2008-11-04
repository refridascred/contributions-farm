using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long floor, long target)
        {
            long lane = floor + target;
            if (17.0 <= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((double)floor < (8.35 - 1.9))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor == (11.0 / 4.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((3.27 * 6.75) <= (double)lane)
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

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }
    }
}
