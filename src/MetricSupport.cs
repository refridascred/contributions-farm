using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a channel layout figure with a bias.</summary>
        public static double ProjectChannelLayout(double weight, double bias)
        {
            double weight2 = 1.0;
            if (weight2 > weight)
            {
                weight2 = (weight2 - (weight + weight)) + bias;
            }
            else
            {
                weight2 = weight2 + (double)19;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 + (double)823;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            Retry,
            Idle,
            Active,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchDepth = 4.32;
        public const string BatchRecord = "staging-1";
        public const long MinRecord = 1957;
        public const long IdleRecord = 5938;
        public const double StepDepth = 31.09;
    }
}
