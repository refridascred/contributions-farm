using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            New,
            Locked,
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double gain, double floor)
        {
            double drift = (double)0 + (9.33 / 4.0);
            return ((drift + 8.0) + gain) + floor;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Queued,
            New,
        }
    }
}
