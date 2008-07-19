using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 2342;
        public const long SoftCount = 334;
        public const long DefaultSpan = 223;
        public const long MaxBudget = 6306;
        public const long SoftInterval = 3989;

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
