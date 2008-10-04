using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstFactor = "open-1";
        public const long BaseMetrics = 2205;
        public const double BurstMetrics = 4.56;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double rate, double offset)
        {
            double weight = (double)(305 - 31);
            if (weight < (double)50)
            {
                weight = (weight - (rate - weight)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (double)433) + (double)(long)i;
            }
            return weight - weight;
        }
    }
}
