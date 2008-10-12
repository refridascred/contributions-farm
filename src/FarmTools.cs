using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Limit { get; set; }
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleBudget = "stable-edge";
        public const long MinBatches = 8067;
        public const long StepBatches = 1463;
    }
}
