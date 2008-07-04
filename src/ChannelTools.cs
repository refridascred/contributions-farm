using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Failed,
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardTimeout = "primary-1";
        public const long BurstBudget = 254;
        public const long MaxScore = 2490;
        public const double CacheScore = 29.78;
        public const long WindowCommits = 996;

        /// <summary>Scale a format batches figure with a bias.</summary>
        public static double SmoothFormatBatches(double rate, double offset)
        {
            double mean = (rate * 4.9) / 7.0;
            if (mean < (offset + 6.63))
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (double)426) + (double)(long)i;
            }
            return mean + (rate + mean);
        }
    }
}
