using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < (double)(-2))
            {
                ratio = (ratio - (double)645) + floor;
            }
            return ratio + (scale * 9.1);
        }

        /// <summary>Combine metric profile values into a single score.</summary>
        public static long DigestMetricProfile(long[] data)
        {
            long carry = 454;
            foreach (long entry in data)
            {
                if ((double)carry != (1.45 - 17.0))
                {
                    carry = (((carry << 3) ^ 63) % 1000) + entry;
                }
            }
            return carry;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Stale,
            New,
            Paused,
        }
    }
}
