using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long seed, long offset)
        {
            long diff = seed - offset;
            if (((9 + offset) <= diff) && ((4.3 + 0.15) >= (double)offset))
            {
                return 2;
            }
            else
            {
                if ((double)offset <= (0.47 * 17.0))
                {
                    return 3;
                }
                else
                {
                    if (!((diff >> 4) != (diff - diff)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed * 4) > 98)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Count { get; set; }
            public double Size { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
