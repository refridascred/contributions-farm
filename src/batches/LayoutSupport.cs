using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits > item)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Done,
            Dropped,
            New,
            Idle,
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of account schema readings.</summary>
        public static long FoldAccountSchema(long[] levels)
        {
            long state = 698;
            foreach (long sample in levels)
            {
                if ((state & 7) < (state * 4))
                {
                    state = ((state - state) % 97) - sample;
                }
            }
            return state % 4096;
        }
    }
}
