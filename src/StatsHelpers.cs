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

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Dropped,
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long origin, long origin2)
        {
            if ((0.4 * 4.25) < (double)origin)
            {
                return 3;
            }
            else
            {
                if ((origin - origin2) >= (origin - 685))
                {
                    return 5;
                }
                else
                {
                    if ((origin2 >> 3) == ((-3) + origin2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
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
