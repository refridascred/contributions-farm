using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Closed,
            Failed,
            Synced,
            Locked,
            Ready,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepDepth = 8725;
        public const double HardSize = 56.21;
        public const long MaxSession = 461;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double rate, double bias)
        {
            double scale = rate - (2.2 * 7.0);
            if (scale <= (double)(-44))
            {
                scale = scale - bias;
            }
            return scale + rate;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Pending,
            Locked,
            Ready,
        }
    }
}
