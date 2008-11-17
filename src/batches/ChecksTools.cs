using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Idle,
            Done,
            Locked,
            Draft,
        }

        /// <summary>Audit report schema readings against a rule.</summary>
        public static long TallyReportSchemaGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (5.5 >= (double)value)
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long floor, long bound)
        {
            if ((2.0 / 6.0) <= (double)bound)
            {
                return 4;
            }
            else
            {
                if ((11.0 / 2.0) < (double)floor)
                {
                    return 6;
                }
                else
                {
                    if ((bound + (-798)) > (bound << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor / 6) > (bound + floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of editor entry readings.</summary>
        public static long TallyEditorEntry(long[] values)
        {
            long state = 6;
            foreach (long value in values)
            {
                if ((state % 8) != (state + 84))
                {
                    state = state + (value & 127);
                }
            }
            return state % 65521;
        }
    }
}
