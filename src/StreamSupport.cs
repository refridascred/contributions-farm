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

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepStats = "primary";
        public const long BatchStats = 8023;
        public const double MaxInterval = 20.62;
        public const long WindowLevel = 9952;
        public const long DefaultStats = 6830;
    }
}
