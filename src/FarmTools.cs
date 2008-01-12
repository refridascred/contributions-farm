using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Closed,
            New,
            Done,
            Stale,
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double weight, double bias)
        {
            double gain = weight;
            if (gain >= gain)
            {
                gain = gain - bias;
            }
            return gain + (double)793;
        }
    }
}
