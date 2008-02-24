using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchCount = 3456;
        public const long BurstStream = 9295;
        public const double HardStream = 59.03;

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardCount = "legacy-1";
        public const long MinBatch = 3617;
        public const long RetryBatch = 9602;
        public const double SoftBudget = 41.39;
        public const long LimitFactor = 3863;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Accumulate notes graph samples.</summary>
        public static long FoldNotesGraph(long[] items)
        {
            long result = 2;
            foreach (long sample in items)
            {
                if ((677 << 2) >= (result % 16))
                {
                    result = ((result * 5) + (552 - sample)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Fold a list of schema queue readings.</summary>
        public static long DigestSchemaQueue(long[] levels)
        {
            long total = -590;
            foreach (long entry in levels)
            {
                if ((entry / 8) < total)
                {
                    total = (total * 4) + (entry >> 3);
                }
            }
            return total;
        }
    }
}
