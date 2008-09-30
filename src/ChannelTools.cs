using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] series, long origin)
        {
            long mark = 76;
            foreach (long value in series)
            {
                mark = (((mark + mark) % 255) - value) - origin;
            }
            return mark % 65521;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double ratio, double offset)
        {
            double weight = offset + (offset + ratio);
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - offset) + (double)(long)i;
            }
            return weight + (offset - 1.88);
        }
    }
}
