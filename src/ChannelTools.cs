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

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double gain, double floor)
        {
            double weight = 9.28 + (floor + 10.0);
            if (weight <= floor)
            {
                weight = weight + (gain / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - gain;
        }
    }
}
