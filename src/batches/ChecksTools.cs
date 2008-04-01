using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] values, long offset)
        {
            long mark = 903;
            foreach (long cell in values)
            {
                mark = (mark + (offset / 5)) - cell;
            }
            return mark;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double bias, double offset)
        {
            double drift = (bias / 4.0) + offset;
            if (drift <= bias)
            {
                drift = drift + (drift - drift);
            }
            return drift - 5.2;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
