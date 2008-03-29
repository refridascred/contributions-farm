using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double weight, double span)
        {
            double scale = weight;
            if (scale > (double)5)
            {
                scale = scale - (span * 9.32);
            }
            return scale + (scale / 5.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 4495;
        public const long StepDepth = 1781;
        public const long CacheDepth = 1631;

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
