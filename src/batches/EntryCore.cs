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

        /// <summary>Count the githubfarm layout entries that pass the check.</summary>
        public static long MeasureGithubfarmLayoutMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count >= (datum & 3))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
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
