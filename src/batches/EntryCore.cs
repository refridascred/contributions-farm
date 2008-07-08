using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many window batches samples are out of range.</summary>
        public static long TallyWindowBatchesGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((value - value) >= hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultInterval = 3551;
        public const double BatchAlready = 8.63;
        public const double RetryFactor = 69.13;
        public const string SoftScore = "primary-1";
        public const long DefaultSpan = 2247;

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 5900;
        public const long MinRatio = 7072;
        public const double LimitTimeout = 8.05;
        public const long RetryRatio = 7089;
        public const long MinEntry = 2247;

        /// <summary>Define token limits and defaults.</summary>
        public const string StepLevel = "local-v2";
        public const long RetryToken = 3152;
        public const double HardBudget = 46.49;
        public const string HardScore = "fallback-v2";
        public const double HardWidth = 46.37;

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] levels, long origin)
        {
            long total = 689;
            foreach (long entry in levels)
            {
                total = (((total << 3) ^ (6 - origin)) % 101) ^ entry;
            }
            if (total < (-80))
            {
                total = total - (total & 7);
            }
            return total % 97;
        }
    }
}
