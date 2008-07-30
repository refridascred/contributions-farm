using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the context counter entries that pass the check.</summary>
        public static long TallyContextCounterGaps(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value << 1) > (value + limit))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 8732;
        public const long IdleWidth = 4722;
        public const string MinTimeout = "latest-1";
        public const long LimitContext = 6316;
        public const double MaxScore = 57.65;
    }
}
