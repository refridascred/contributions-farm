using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 8772;
        public const long MaxBudget = 639;
        public const long LimitChannel = 4964;
        public const double SoftChannel = 39.66;

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double rate, double span)
        {
            double bias = rate;
            if (bias > (rate - bias))
            {
                bias = (bias + 15.0) + span;
            }
            return bias - rate;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Synced,
            Ready,
            Queued,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Label { get; set; }
            public bool Offset { get; set; }
        }
    }
}
