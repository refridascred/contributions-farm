using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double rate, double offset)
        {
            double scale = 6.0;
            for (int i = 0; i < 6; i++)
            {
                scale = (((scale - (scale * 3.0)) + (double)(long)i) - rate) - offset;
            }
            return scale - scale;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Done,
            Pending,
            Queued,
            Synced,
            Paused,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseInterval = 65.25;
        public const long IdleMetric = 2170;
        public const double RetryLevel = 45.33;
    }
}
