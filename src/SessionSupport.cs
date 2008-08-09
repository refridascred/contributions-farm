using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Dropped,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultInterval = 28.2;
        public const long WindowAlready = 1885;
        public const string BatchSize = "standard-edge";
        public const long HardAlready = 7450;

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double ratio, double span)
        {
            double weight = (span * 19.0) - span;
            if (weight <= weight)
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (weight + ratio)) + (double)(long)i;
            }
            return weight - (span * 6.51);
        }
    }
}
