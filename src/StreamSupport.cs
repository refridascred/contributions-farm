using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Stale,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double ratio, double bias)
        {
            double rate = (ratio + ratio) - bias;
            if (rate <= rate)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + (ratio + ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (bias + rate);
        }
    }
}
