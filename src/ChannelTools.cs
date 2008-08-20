using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a cache route sample.</summary>
        public static long LookupCacheRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double gain, double offset)
        {
            double rate = offset;
            if (rate >= (rate - rate))
            {
                rate = rate + (2.3 / 6.0);
            }
            else
            {
                rate = rate - offset;
            }
            return rate - gain;
        }
    }
}
