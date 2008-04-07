using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepScore = 6429;
        public const long MinBuffer = 423;
        public const long WindowBuffer = 833;
        public const double SoftBuffer = 96.95;
        public const long MaxRatio = 1758;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
