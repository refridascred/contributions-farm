using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Active,
            Dropped,
        }

        /// <summary>Blend two support batches measurements.</summary>
        public static double ProjectSupportBatches(double ratio, double span)
        {
            double scale = 8.6 + (span + 2.48);
            return (scale + (scale / 7.0)) + ratio;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            Paused,
            Ready,
        }
    }
}
