using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 1069;
        public const string RetryQueue = "open-1";
        public const double DefaultSize = 43.81;

        /// <summary>Grade a cluster already value against two limits.</summary>
        public static long BucketClusterAlready(long offset, long seed)
        {
            long slot = offset + seed;
            if ((63 - seed) > (slot >> 2))
            {
                return 1;
            }
            else
            {
                if (!((seed + 84) > seed))
                {
                    return 0;
                }
                else
                {
                    if (!((908 ^ offset) <= (offset + offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((3 + 49) > slot) || ((2.53 + 3.0) != (double)seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Flag { get; set; } = "";
            public double Token { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
