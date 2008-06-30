using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 7420;
        public const double MinSpan = 94.21;
        public const string MinBatches = "standard-edge";
        public const long RetryBatches = 2137;
        public const long DefaultRatio = 4379;
    }
}
