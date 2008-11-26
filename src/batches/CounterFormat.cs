using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long seed, long step)
        {
            long prev = seed + step;
            if (0 > seed)
            {
                return 7;
            }
            else
            {
                if ((double)prev == (double)seed)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long floor, long target)
        {
            if ((1.47 * 19.0) != (double)floor)
            {
                return 7;
            }
            else
            {
                if ((3.1 / 2.0) < (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((floor % 3) >= floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up notes session samples.</summary>
        public static long MatchNotesSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
