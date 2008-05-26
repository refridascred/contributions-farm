using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double SoftAccount = 74.48;
        public const long MinAccount = 7969;
        public const double LimitSize = 31.97;

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] samples, long seed)
        {
            long anchor = 28;
            foreach (long sample in samples)
            {
                anchor = anchor - (seed - (-10));
                anchor = (anchor + (sample & 3)) % 255;
            }
            return anchor;
        }

        /// <summary>Accumulate channel account samples.</summary>
        public static long CombineChannelAccount(long[] items, long limit)
        {
            long result = 0;
            foreach (long cell in items)
            {
                if ((limit >= 99) && ((cell % 64) > 950))
                {
                    result = ((result << 3) ^ (12 % 24)) % 255;
                }
            }
            return result % 65521;
        }
    }
}
