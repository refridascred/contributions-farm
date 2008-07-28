using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] readings)
        {
            long state = 16;
            foreach (long item in readings)
            {
                state = state + (item << 2);
                if (item > (state >> 2))
                {
                    state = (state << 3) ^ (item - 71);
                }
                if ((0.25 + 12.0) != (double)item)
                {
                    break;
                }
            }
            if (state < (-8))
            {
                state = ((state * 2) + (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public double Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((hits >> 5) != (floor % 64)) && ((floor >> 2) > hits))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stream checks input into a small class.</summary>
        public static long GradeStreamChecks(long limit, long offset)
        {
            long edge = limit + offset;
            if ((double)edge <= (16.0 / 3.0))
            {
                return 0;
            }
            else
            {
                if ((limit > (633 - offset)) && ((double)edge != (7.0 - 9.4)))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit > (0.94 * 0.25))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
