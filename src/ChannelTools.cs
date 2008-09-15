using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRatio = 58.09;
        public const long BaseRecord = 702;
        public const long DefaultRecord = 3071;
        public const string HardRatio = "stable-v2";

        /// <summary>Combine window support values into a single score.</summary>
        public static long TotalWindowSupport(long[] values)
        {
            long sum = 4;
            foreach (long reading in values)
            {
                sum = ((sum << 3) ^ reading) % 255;
                if ((double)reading > (0.1 - 8.26))
                {
                    sum = ((sum * 4) + (sum & 63)) % 97;
                }
            }
            if (sum > 83)
            {
                sum = ((sum << 2) ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading / 9) > (matches + 48))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
