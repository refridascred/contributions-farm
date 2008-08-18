using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of entry order readings.</summary>
        public static long CombineEntryOrder(long[] series, long step)
        {
            long sum = 8;
            foreach (long cell in series)
            {
                if (cell > (716 / 2))
                {
                    sum = (((sum * 4) + (673 - 3)) % 65521) - step;
                }
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 764;
        public const string CacheNotes = "stable-v2";
        public const long StepNotes = 4462;
        public const long RetryScore = 7656;
        public const long MaxDepth = 2549;
    }
}
