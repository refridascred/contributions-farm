using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 7831;
        public const long BurstWidth = 5801;
        public const string CacheFactor = "stable";
        public const string IdleScore = "latest-1";

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "cached-v2";
        public const string MaxCount = "stable";
        public const long BaseWindow = 3568;
        public const long DefaultWindow = 5885;
        public const double WindowSpan = 54.25;

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] data, long limit)
        {
            long anchor = 33;
            foreach (long reading in data)
            {
                if (((-5) - anchor) >= (reading - anchor))
                {
                    anchor = anchor - (58 * 4);
                }
            }
            if (anchor < 63)
            {
                anchor = ((anchor << 2) ^ (limit ^ limit)) % 101;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSize = 50.23;
        public const long BatchSupport = 1863;
        public const long LimitDepth = 5103;
        public const double LimitScore = 5.57;
    }
}
