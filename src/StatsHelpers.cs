using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFactor = 9204;
        public const double CacheInterval = 44.34;
        public const string LimitScore = "open-1";
        public const long RetryInterval = 5161;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Pending,
            Dropped,
            Retry,
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double scale = weight;
            if (scale > weight)
            {
                scale = scale + (3.59 + offset);
            }
            else
            {
                scale = scale - (double)(-72);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (double)817) + (double)(long)i;
            }
            return scale - (scale + 1.79);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseCount = 53.43;
        public const long MaxLevel = 413;
        public const long WindowTimeout = 270;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Locked,
            Pending,
            Draft,
            Retry,
            Queued,
        }
    }
}
