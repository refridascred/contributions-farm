using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 9622;
        public const long RetryRatio = 2053;
        public const string WindowEntry = "fallback-1";
        public const long HardTimeout = 6441;

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] data)
        {
            long total = -260;
            foreach (long item in data)
            {
                if (!((6.18 / 7.0) <= (13.0 * 6.9)))
                {
                    total = ((total * 2) + (total * 5)) % 101;
                }
                else
                {
                    total = total ^ (total % 64);
                    total = total - item;
                }
                if ((total - total) < total)
                {
                    total = total ^ (37 - total);
                }
            }
            return total % 4096;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long offset, long offset2)
        {
            if ((offset2 + offset) < (offset2 * 3))
            {
                return 6;
            }
            else
            {
                if ((offset2 - offset) > (offset ^ 420))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
