using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Region { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long offset, long step)
        {
            if (((20.0 - 6.0) > (double)step) && ((offset - offset) != (offset << 2)))
            {
                return 2;
            }
            else
            {
                if (2.0 < (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 > 3.1)
            {
                bias2 = (bias2 + (double)24) + bias;
            }
            return bias2 - (double)0;
        }
    }
}
