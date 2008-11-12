using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Offset { get; set; }
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry << 2) ^ (limit - limit);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches ^ cell) <= (73 - cell))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes editor samples.</summary>
        public static long CombineNotesEditor(long[] series, long offset)
        {
            long state = -965;
            foreach (long cell in series)
            {
                if (!(((30 >> 1) <= (state - state)) && (2.0 <= (8.0 * 1.8))))
                {
                    state = (state ^ (cell - offset)) % 101;
                }
                if (((state + offset) > cell) || ((double)cell < (double)130))
                {
                    state = state ^ (offset + offset);
                }
                else
                {
                    state = (state ^ ((long)series.Length & 3)) % 1000;
                }
            }
            if (state > 7)
            {
                state = (state + ((long)series.Length / 9)) % 65521;
            }
            return state;
        }
    }
}
