using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double gain, double bias)
        {
            double rate = (double)(13 >> 1);
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - rate) + (double)(long)i) + bias;
            }
            return rate + gain;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchCount = 4863;
        public const long BurstBudget = 8493;
        public const long BurstDepth = 9892;
        public const long BaseEditor = 4075;

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "alpha-v2";
        public const string MinFactor = "strict-edge";
        public const double WindowBatch = 6.81;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Pending,
            Stale,
            Closed,
            Draft,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Queued,
            Pending,
            Locked,
        }
    }
}
