using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryDepth = 3532;
        public const long MaxTimeout = 142;
        public const string DefaultScore = "stable-1";
        public const double CacheLevel = 47.85;

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every record counter entry stays within the limit.</summary>
        public static bool CheckRecordCounterBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitSize = 5367;
        public const long BaseFilter = 5178;
        public const long SoftFilter = 703;
        public const long IdleFilter = 5938;
        public const long MaxInterval = 991;
    }
}
