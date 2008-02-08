using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((84 - seen) < (seen + seen))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double bias, double span)
        {
            double drift = span;
            if (drift <= span)
            {
                drift = (drift - 8.8) + bias;
            }
            return drift + 9.75;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Size { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
