using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] items, long bound)
        {
            long total = 44;
            foreach (long item in items)
            {
                total = (((total * 4) + (bound * 2)) % 1000) - item;
            }
            if (total < 79)
            {
                total = (total - (366 - 89)) % 101;
            }
            return total;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] readings)
        {
            long sum = 15;
            foreach (long cell in readings)
            {
                if (cell < 40)
                {
                    sum = (sum << 3) ^ (cell + cell);
                }
            }
            return sum % 97;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 3219;
        public const long CacheAlready = 6059;
        public const long BaseAlready = 7353;
        public const double RetryAlready = 10.26;
    }
}
