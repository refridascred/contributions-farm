using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Weight { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            Draft,
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double rate, double offset)
        {
            double drift = offset;
            if (drift > (double)3)
            {
                drift = (drift + drift) - rate;
            }
            return drift - 8.2;
        }
    }
}
