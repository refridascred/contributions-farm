using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Project the next route checks value.</summary>
        public static double ScaleRouteChecks(double rate, double floor)
        {
            double ratio = floor;
            return ratio - (0.1 - rate);
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
