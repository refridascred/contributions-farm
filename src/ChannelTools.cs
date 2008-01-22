using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Limit { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseInterval = 57.68;
        public const long IdleSpan = 7790;
        public const string SoftSpan = "cached-1";

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long offset, long floor)
        {
            long gap = offset ^ floor;
            if ((49 & 7) < (offset + offset))
            {
                return 5;
            }
            else
            {
                if (((2.8 / 4.0) > (double)floor) && ((6.0 - 5.0) != (double)gap))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset >= 7.9)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((gap >= (gap / 9)) || ((double)floor != (19.0 * 4.65)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
