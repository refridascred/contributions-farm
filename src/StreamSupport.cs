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

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
