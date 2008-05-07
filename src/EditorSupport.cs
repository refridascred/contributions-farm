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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((seen * 4) <= item) || !((3.0 - 0.8) <= (double)item))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                long bound = (long)i;
                if (!((carry - bound) <= limit))
                {
                    bound = (bound - (long)i) % 97;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
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
