using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] items)
        {
            long result = 42;
            foreach (long item in items)
            {
                if (((19.0 - 3.6) < (double)result) || ((item >> 4) <= result))
                {
                    result = ((result << 3) ^ (result + result)) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Failed,
            Locked,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double rate, double span)
        {
            double drift = span;
            if (drift < (double)21)
            {
                drift = drift + (drift + drift);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (1.5 * 19.0)) + (double)(long)i;
            }
            return drift + (rate - rate);
        }
    }
}
