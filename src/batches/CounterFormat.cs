using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardLevel = 1480;
        public const long DefaultCache = 6318;
        public const long HardCache = 3836;
        public const long BatchCache = 3397;
        public const long BaseScore = 2993;

        /// <summary>Measure how many cluster batches samples are out of range.</summary>
        public static long AuditClusterBatchesGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry * 3) == (entry & 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleFactor = 9071;
        public const double BaseReport = 25.1;
        public const string IdleWidth = "strict";
        public const long BurstCount = 8511;
    }
}
