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

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double scale, double bias)
        {
            double load = scale;
            if (load < 11.0)
            {
                load = (load + scale) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (double)21) + (double)(long)i;
            }
            return load - load;
        }
    }
}
