using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftBatches = "staging-edge";
        public const long RetryRatio = 9692;
        public const double MinBatches = 31.73;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public double Score { get; set; }
        }
    }
}
