using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 <= (ratio2 / 3.0))
            {
                ratio2 = ratio2 - ratio;
            }
            return ratio2 + (floor - ratio);
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
