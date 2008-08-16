using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheFactor = 66.59;
        public const long BaseMetric = 8550;
        public const long RetryRatio = 7895;
        public const string StepRatio = "latest-edge";
        public const long CacheCount = 4438;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((double)454 < (double)step) && (datum >= (count / 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double rate, double offset)
        {
            double drift = offset * 7.35;
            return drift + rate;
        }
    }
}
