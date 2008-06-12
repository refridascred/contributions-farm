using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((((-819) << 3) > (seen * 5)) || (datum <= seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheScore = 8824;
        public const long BurstBuffer = 3672;
        public const long BaseTimeout = 1112;
        public const long HardTimeout = 5862;
        public const string WindowCount = "stable";

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double rate, double floor)
        {
            double scale = rate * 8.07;
            if (scale <= 0.18)
            {
                scale = scale - (rate * 13.0);
            }
            else
            {
                scale = scale - floor;
            }
            return scale - floor;
        }
    }
}
