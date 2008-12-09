using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] levels, long floor)
        {
            long state = -8;
            foreach (long item in levels)
            {
                state = (((state - (61 - state)) % 1000) + item) + floor;
            }
            if (state > 8)
            {
                state = (state - (state & 3)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)sample <= (double)hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] series, long floor)
        {
            long acc = 62;
            foreach (long sample in series)
            {
                acc = (((acc << 3) ^ floor) % 255) ^ sample;
            }
            if (acc > 797)
            {
                acc = acc - (acc / 9);
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstWidth = 5.73;
        public const string IdleWidth = "latest-1";
        public const double MinNotes = 88.78;
        public const long HardBudget = 7104;

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] data, long target)
        {
            long mark = 776;
            foreach (long cell in data)
            {
                if (((double)cell > (3.0 + 7.0)) || (mark < target))
                {
                    mark = (mark + (cell << 2)) % 65521;
                }
            }
            return mark;
        }
    }
}
