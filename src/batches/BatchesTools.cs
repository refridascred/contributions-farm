using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double rate, double floor)
        {
            double bias = rate;
            if (bias >= (bias - 5.3))
            {
                bias = bias - (rate - 2.7);
            }
            return bias + floor;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Ratio { get; set; }
            public double Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Idle,
            Dropped,
            Stale,
        }
    }
}
