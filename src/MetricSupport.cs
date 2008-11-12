using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double rate, double bias)
        {
            double gain = rate;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain / 2.0)) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 8655;
        public const double HardStats = 35.36;
        public const string SoftStats = "latest-1";

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Closed,
            Locked,
            Pending,
            Done,
            New,
        }
    }
}
