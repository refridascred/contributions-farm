using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public bool Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardDepth = 70.24;
        public const double MinNotes = 70.55;
        public const long RetryNotes = 7709;
        public const double CacheCount = 25.22;
        public const long BurstCount = 2816;

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double rate, double offset)
        {
            double rate2 = (double)409 * 15.0;
            if (rate2 < (11.0 - offset))
            {
                rate2 = rate2 + 6.2;
            }
            else
            {
                rate2 = rate2 - (rate / 4.0);
            }
            return rate2 + rate2;
        }
    }
}
