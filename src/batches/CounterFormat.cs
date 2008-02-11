using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double scale, double bias)
        {
            double drift = bias;
            if (drift >= scale)
            {
                drift = drift - (9.9 * 19.0);
            }
            return drift + (double)17;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            Closed,
            Synced,
            Queued,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public bool Total { get; set; }
        }
    }
}
