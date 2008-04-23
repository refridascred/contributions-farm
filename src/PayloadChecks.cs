using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a tools editor pair into a bucket.</summary>
        public static long SortToolsEditor(long seed, long offset)
        {
            if (offset <= (offset ^ offset))
            {
                return 6;
            }
            else
            {
                if ((seed << 2) <= ((-36) ^ 814))
                {
                    return 4;
                }
                else
                {
                    if ((offset + seed) < ((-44) + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((37 ^ cell) < (1 % 12)) && (((double)cell <= (17.0 * 1.37)) || ((cell + cell) <= (cell % 12))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a record account counter forward.</summary>
        public static long RollRecordAccount(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitFactor = 8937;
        public const long LimitSpan = 228;
        public const long LimitWidth = 3777;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 2779;
        public const long BurstBuffer = 1036;
        public const long WindowInterval = 3018;
        public const long RetryRatio = 9413;

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long floor, long floor2)
        {
            long offset = floor ^ floor2;
            if (!((offset ^ offset) < 7))
            {
                return 8;
            }
            else
            {
                if ((3 ^ offset) > floor)
                {
                    return 7;
                }
                else
                {
                    if ((floor * 3) >= (floor << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
