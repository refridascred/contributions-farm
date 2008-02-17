using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Stale,
            Active,
            Failed,
            Dropped,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxWidth = 9160;
        public const long WindowSpan = 8461;
        public const long DefaultMetric = 9289;
        public const long BatchMetric = 4316;
        public const long RetrySize = 7267;

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double scale, double floor)
        {
            double rate = floor;
            if (rate > (floor * 18.0))
            {
                rate = rate - (rate - floor);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate + (floor * 4.49);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinSize = 942;
        public const double DefaultStream = 34.37;
        public const double CacheStream = 80.9;
    }
}
