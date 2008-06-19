using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a graph cache sample.</summary>
        public static long FindGraphCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] values, long limit)
        {
            long anchor = -6;
            foreach (long reading in values)
            {
                if (((limit >> 4) < (anchor % 5)) && ((double)anchor > (11.0 - 7.4)))
                {
                    anchor = (anchor ^ limit) + reading;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Size { get; set; } = "";
            public bool Count { get; set; }
            public long Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] items, long origin)
        {
            long total = 99;
            foreach (long sample in items)
            {
                if ((origin ^ origin) != (4 & 1))
                {
                    total = total + (total - sample);
                }
                if (((9.8 + 4.8) >= (double)total) || ((sample + total) >= origin))
                {
                    break;
                }
            }
            return total;
        }
    }
}
