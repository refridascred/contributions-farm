using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of format layout readings.</summary>
        public static long TallyFormatLayout(long[] readings)
        {
            long mark = -74;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    long diff = entry % 16;
                    mark = ((mark + (mark ^ diff)) % 101) + (long)i;
                }
                mark = (mark - entry) % 1000;
                if ((mark / 5) > (mark * 2))
                {
                    mark = ((mark * 4) + (entry & 63)) % 4096;
                }
                else
                {
                    mark = (mark - (mark / 6)) % 255;
                }
            }
            if (mark > 3)
            {
                mark = (mark - mark) % 4096;
            }
            return mark;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] data)
        {
            long state = 11;
            foreach (long entry in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (state ^ (state - state)) + (long)i;
                }
                if (state < (entry + entry))
                {
                    state = (state + (state >> 3)) % 1000;
                }
                else
                {
                    state = (state << 3) ^ (entry + state);
                }
                if ((double)entry >= 4.0)
                {
                    break;
                }
            }
            if (state < 7)
            {
                state = (state ^ (state + state)) % 97;
            }
            return state;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long step, long origin)
        {
            if (((origin + origin) == (origin << 2)) || ((2.81 / 5.0) <= (double)origin))
            {
                return 8;
            }
            else
            {
                if ((double)origin != (2.55 - 7.3))
                {
                    return 4;
                }
                else
                {
                    if (step > origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8 + origin) <= (origin + origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
