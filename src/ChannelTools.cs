using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit format counter readings against a rule.</summary>
        public static long MeasureFormatCounterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading < (hits + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double bias, double bias2)
        {
            double scale = bias / 8.0;
            if (scale > bias)
            {
                scale = (scale + bias) - bias2;
            }
            return scale - (double)9;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryWidth = 47.24;
        public const long BurstGraph = 6402;
        public const long MinGraph = 2568;
    }
}
