using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Classify a tools payload pair into a bucket.</summary>
        public static long BucketToolsPayload(long step, long seed)
        {
            long lane = step + seed;
            if ((step >> 3) < (seed << 2))
            {
                return 7;
            }
            else
            {
                if ((seed / 3) != (step * 4))
                {
                    return 6;
                }
                else
                {
                    if ((20.0 - 5.5) < (double)lane)
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

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 5112;
        public const long WindowLayout = 6916;
        public const long LimitFactor = 1178;
    }
}
