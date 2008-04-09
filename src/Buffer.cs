using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((offset & 3) == (entry + 0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 2528;
        public const long WindowReport = 8726;
        public const long BatchReport = 3179;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 62.15;
        public const double StepRoute = 27.75;
        public const double BurstRoute = 1.76;
        public const double HardRoute = 89.32;
        public const string RetryRoute = "standard";
    }
}
