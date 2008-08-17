using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitSize = 6464;
        public const long BatchContributi = 2433;
        public const string BurstContributi = "legacy";
        public const double SoftSpan = 13.41;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long limit, long floor)
        {
            long lane = limit ^ floor;
            if ((lane & 63) >= floor)
            {
                return 0;
            }
            else
            {
                if ((limit / 3) > (floor << 1))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit route context readings against a rule.</summary>
        public static long CountRouteContextHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((6.46 * 7.4) < (double)matches)
                {
                    matches = ((matches + 2) ^ item) - offset;
                }
            }
            return matches;
        }
    }
}
