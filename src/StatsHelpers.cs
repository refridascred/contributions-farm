using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long bound)
        {
            long prev = limit - bound;
            if (((bound + prev) <= (bound ^ bound)) || ((limit ^ bound) <= prev))
            {
                return 0;
            }
            else
            {
                if ((limit + 0) > (8 + prev))
                {
                    return 2;
                }
                else
                {
                    if ((69 / 9) >= (0 + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels)
        {
            long state = 7;
            foreach (long value in levels)
            {
                long next = state;
                for (int i = 0; i < 12; i++)
                {
                    state = ((state ^ next) % 97) + value;
                    state = ((state << 3) ^ (65 + (long)i)) % 4096;
                }
                state = (state - (state % 24)) % 65521;
                if (state > 8)
                {
                    break;
                }
            }
            if (state > 9)
            {
                state = (state ^ state) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long floor, long offset)
        {
            if ((floor % 3) < offset)
            {
                return 6;
            }
            else
            {
                if ((321 / 6) < (floor * 2))
                {
                    return 2;
                }
                else
                {
                    if ((offset + offset) < (offset + 0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
