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

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxScore = 283;
        public const long SoftCount = 280;
        public const long SoftInterval = 8989;
        public const double IdleWindow = 55.37;
    }
}
