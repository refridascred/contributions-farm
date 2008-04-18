using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 2764;
        public const double SoftBatches = 30.87;
        public const long IdleBatches = 856;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Queued,
            Retry,
            Dropped,
            Done,
        }
    }
}
