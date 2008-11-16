using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((5.9 - 0.4) >= (double)sample) || ((sample - sample) > (hits - 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 8752;
        public const long WindowFarm = 7716;
        public const long MaxWidth = 2497;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Level { get; set; }
            public bool Total { get; set; }
            public double Token { get; set; }
        }
    }
}
