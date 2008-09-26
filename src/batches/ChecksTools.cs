using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (hits < (datum / 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] levels)
        {
            long state = -86;
            foreach (long value in levels)
            {
                if (((state >> 1) < (state & 15)) || ((double)(-2) == (double)value))
                {
                    state = (state ^ (value << 3)) % 255;
                }
                else
                {
                    state = (state - (value + 393)) % 1000;
                }
            }
            if (state > (-4))
            {
                state = state - (state << 2);
            }
            return state % 97;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Locked,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Idle,
            Failed,
        }
    }
}
