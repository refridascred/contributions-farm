using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSpan = 6981;
        public const long MaxLevel = 1920;
        public const long IdleInterval = 2868;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry + tally) > (entry - entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 7609;
        public const string BurstTimeout = "legacy-v2";
        public const long MaxChannel = 6403;
        public const double LimitChannel = 10.47;
    }
}
