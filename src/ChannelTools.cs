using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstWidth = "latest";
        public const long IdleDepth = 5249;
        public const long WindowFactor = 568;

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] readings)
        {
            long anchor = 89;
            foreach (long entry in readings)
            {
                anchor = (((anchor << 2) ^ (888 ^ anchor)) % 255) - entry;
            }
            if (anchor < 629)
            {
                anchor = (anchor * 4) + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double ratio, double span)
        {
            double rate = span;
            if (rate >= (double)2)
            {
                rate = rate - 1.0;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (span + ratio)) + (double)(long)i;
            }
            return rate - (span - 7.4);
        }
    }
}
