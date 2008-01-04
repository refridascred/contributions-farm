using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Size { get; set; }
            public double Token { get; set; }
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double rate, double span)
        {
            double bias = (span / 4.0) - 18.0;
            if (bias < (double)4)
            {
                bias = bias + span;
            }
            else
            {
                bias = bias - (bias / 3.0);
            }
            return bias + (rate - 6.4);
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Idle,
            Ready,
            Stale,
            Draft,
        }
    }
}
