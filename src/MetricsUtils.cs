using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((30 + reading) < (bound + reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] values, long floor)
        {
            long result = -6;
            foreach (long entry in values)
            {
                if ((double)entry == (double)result)
                {
                    result = (result - (floor + result)) % 101;
                }
                else
                {
                    result = result ^ entry;
                }
            }
            if (result > 9)
            {
                result = (result + 1) % 97;
            }
            return result % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 5387;
        public const long HardBatch = 8657;
        public const long DefaultScore = 2680;

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
