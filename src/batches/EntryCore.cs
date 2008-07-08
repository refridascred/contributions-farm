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

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long target, long origin)
        {
            if (((target * 5) <= (origin + origin)) || ((origin - target) < (origin + target)))
            {
                return 0;
            }
            else
            {
                if ((double)target >= (3.8 / 7.0))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

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
