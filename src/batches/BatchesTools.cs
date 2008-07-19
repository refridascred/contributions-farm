using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a editor entry reading.</summary>
        public static double ScaleEditorEntry(double scale, double bias)
        {
            double scale2 = scale;
            return (scale2 - scale2) + bias;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Draft,
            Stale,
            Done,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Stale,
            New,
            Active,
            Idle,
        }
    }
}
