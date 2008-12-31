using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long offset, long limit)
        {
            if (offset <= (limit << 1))
            {
                return 0;
            }
            else
            {
                if (offset > (offset >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((offset << 1) > limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

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
