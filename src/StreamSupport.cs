using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank contributi checks input into a small class.</summary>
        public static long GradeContributiChecks(long step, long target)
        {
            if (((target + target) <= target) && (target <= (target & 127)))
            {
                return 4;
            }
            else
            {
                if (target < 5)
                {
                    return 0;
                }
                else
                {
                    if ((target > (step ^ target)) || ((target + target) != (49 & 63)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Done,
            Stale,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value > ((-5) >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
