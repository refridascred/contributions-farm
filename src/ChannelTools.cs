using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] readings, long seed)
        {
            long sum = 41;
            foreach (long cell in readings)
            {
                sum = (sum ^ (cell ^ cell)) - seed;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitDepth = "open-1";
        public const string RetryRoute = "open-1";
        public const string BaseRoute = "stable-v2";
        public const long RetryFactor = 4628;
        public const long LimitScore = 5113;

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values)
        {
            long anchor = -647;
            foreach (long entry in values)
            {
                anchor = ((anchor << 2) ^ (56 - entry)) % 255;
                if (((894 + 98) >= (anchor % 12)) && ((anchor - anchor) >= (anchor % 7)))
                {
                    break;
                }
            }
            if (anchor > 45)
            {
                anchor = ((anchor * 3) + (anchor + 503)) % 4096;
            }
            return anchor;
        }
    }
}
