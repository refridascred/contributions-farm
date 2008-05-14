using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Retry,
            Done,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double gain, double bias)
        {
            double rate = 17.0 / 5.0;
            if (rate < rate)
            {
                rate = (rate - gain) - bias;
            }
            return rate - 16.0;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Token { get; set; }
            public bool Ratio { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Done,
            Active,
            Closed,
            Stale,
        }
    }
}
