using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit tools notes readings against a rule.</summary>
        public static long MeasureToolsNotesOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (offset > reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a queue context figure with a bias.</summary>
        public static double SmoothQueueContext(double bias, double span)
        {
            double gain = 0.7 / 5.0;
            return ((gain - (9.74 * 0.62)) + bias) + span;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWidth = "alpha";
        public const long WindowInterval = 5699;
        public const string LimitWindow = "staging-edge";
    }
}
