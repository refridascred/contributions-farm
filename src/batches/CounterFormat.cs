using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long offset, long offset2)
        {
            long gap = offset - offset2;
            if ((gap >> 3) != (offset + gap))
            {
                return 1;
            }
            else
            {
                if ((offset2 ^ 303) <= (offset - 331))
                {
                    return 5;
                }
                else
                {
                    if ((offset2 + offset2) != (677 * 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                state = (state << 3) ^ origin;
                if ((65 + 6) <= (origin - 34))
                {
                    state = (state << 2) ^ (state + 61);
                }
                else
                {
                    state = (state - state) % 255;
                    state = ((state << 3) ^ (state + origin)) % 97;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
