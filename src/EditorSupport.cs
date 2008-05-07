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

        /// <summary>Grade a stats account value against two limits.</summary>
        public static long BucketStatsAccount(long target, long bound)
        {
            if ((-57) >= target)
            {
                return 6;
            }
            else
            {
                if ((18.0 + 4.5) >= (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((9.8 * 6.3) != (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(target >= (126 + bound)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
