using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] levels)
        {
            long total = 621;
            foreach (long entry in levels)
            {
                if ((entry >> 4) <= total)
                {
                    total = (total + (entry / 6)) % 4096;
                }
                else
                {
                    total = (total << 3) ^ 51;
                }
                total = total + 4;
            }
            return total;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 2533;
        public const long LimitWidth = 3454;
        public const long CacheBatches = 7820;
        public const long WindowBatches = 9968;
        public const long BurstBatches = 3125;
    }
}
