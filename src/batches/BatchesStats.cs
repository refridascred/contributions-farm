using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Stale,
            Done,
            Synced,
            Dropped,
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double bias, double offset)
        {
            double gain = (double)40 - (19.0 * 13.0);
            if (gain > (offset + gain))
            {
                gain = (gain + (double)517) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (double)97) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstEditor = 3.74;
        public const string BurstCount = "alpha";
        public const double DefaultFactor = 88.66;

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double bias, double offset)
        {
            double scale = (double)(29 ^ 2);
            return ((scale + scale) + bias) + offset;
        }
    }
}
