using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 5516;
        public const double HardBudget = 86.56;
        public const long LimitFilter = 4101;
        public const string DefaultFilter = "strict-1";

        /// <summary>Grade a account session value against two limits.</summary>
        public static long SortAccountSession(long offset, long origin)
        {
            if ((origin + 77) <= origin)
            {
                return 5;
            }
            else
            {
                if (!((30 * 4) <= offset))
                {
                    return 2;
                }
                else
                {
                    if (0 > (origin & 15))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((86 >> 4) <= (origin - offset)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 4253;
        public const double SoftNotes = 67.94;
        public const long StepInterval = 2624;
        public const string BaseScore = "open";

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Closed,
            Done,
            Draft,
            Dropped,
            Stale,
        }
    }
}
