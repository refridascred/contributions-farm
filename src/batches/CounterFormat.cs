using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item << 3) > (count + count))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxCount = 62.24;
        public const long MaxLevel = 1348;
        public const string MinMetrics = "open-v2";
        public const string BaseBudget = "legacy-v2";

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] samples, long offset)
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
    }
}
