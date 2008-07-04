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

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheSpan = 1484;
        public const long MaxBudget = 2524;
        public const double WindowFilter = 37.92;

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
