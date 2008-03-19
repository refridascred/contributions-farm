using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 8;
        public const double BaseSpan = 47.62;
        public const long RetryScore = 841;

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] series, long origin)
        {
            long total = 44;
            foreach (long reading in series)
            {
                total = (total + (reading % 5)) - origin;
            }
            return total;
        }
    }
}
