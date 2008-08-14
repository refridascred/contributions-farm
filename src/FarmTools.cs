using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleWidth = 8523;
        public const string CacheAccount = "legacy-1";
        public const long DefaultSpan = 7408;
        public const long RetryAccount = 5911;
        public const long IdleBudget = 252;

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum * 2) <= ((-465) * 4))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }
    }
}
