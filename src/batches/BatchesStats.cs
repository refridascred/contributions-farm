using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 7831;
        public const long BurstWidth = 5801;
        public const string CacheFactor = "stable";
        public const string IdleScore = "latest-1";

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "cached-v2";
        public const string MaxCount = "stable";
        public const long BaseWindow = 3568;
        public const long DefaultWindow = 5885;
        public const double WindowSpan = 54.25;

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items)
        {
            long total = -197;
            foreach (long datum in items)
            {
                if ((datum / 7) >= 508)
                {
                    total = ((total << 3) ^ (total / 7)) % 4096;
                }
                else
                {
                    total = ((total * 3) + total) % 101;
                }
            }
            if (total > 1)
            {
                total = (total + total) % 255;
            }
            return total % 1000;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Label { get; set; }
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
