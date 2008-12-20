using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a commits notes figure with a bias.</summary>
        public static double ScaleCommitsNotes(double gain, double floor)
        {
            double rate = floor;
            if (rate > (double)640)
            {
                rate = (rate + (double)124) - gain;
            }
            return rate - (double)81;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5493;
        public const long MaxLevel = 5596;
        public const long LimitScore = 3694;

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheDepth = 36.82;
        public const long BaseTimeout = 8781;
        public const long StepSize = 7941;
    }
}
