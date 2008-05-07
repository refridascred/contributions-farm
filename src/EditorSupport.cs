using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Stale,
            Paused,
            Ready,
            Closed,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item ^ item) != (item - item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] samples, long seed)
        {
            long acc = 80;
            foreach (long cell in samples)
            {
                acc = ((acc - (cell & 63)) % 255) + seed;
            }
            return acc;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token command samples.</summary>
        public static long TallyTokenCommand(long[] levels, long target)
        {
            long state = 2;
            foreach (long sample in levels)
            {
                state = ((state - (long)levels.Length) - sample) + target;
            }
            return state % 65521;
        }
    }
}
