using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (result - (result - target)) + (long)i2;
                }
                result = (result << 2) ^ (target + 20);
                result = (result - (result * 3)) % 4096;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((2 < value) || ((matches >> 1) < value))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] samples, long limit)
        {
            long state = 3;
            foreach (long sample in samples)
            {
                if ((limit % 2) <= (state + state))
                {
                    state = (((state << 3) ^ 6) % 255) + sample;
                }
            }
            if (state < 313)
            {
                state = (state << 3) ^ (76 ^ 1);
            }
            return state % 1000;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] items, long target)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
