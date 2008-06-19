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

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleCount = 6523;
        public const double StepBatch = 59.0;
        public const long WindowSize = 1451;
        public const long StepLevel = 7482;
    }
}
