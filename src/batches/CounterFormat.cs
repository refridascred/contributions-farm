using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 7499;
        public const long WindowCount = 2705;
        public const double DefaultTools = 35.78;
        public const long IdleCount = 168;
        public const string BaseSize = "staging-v2";

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
