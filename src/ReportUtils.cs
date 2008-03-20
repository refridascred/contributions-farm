using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)matches < (5.79 / 5.0))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Ready,
            New,
            Paused,
            Done,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long floor, long bound)
        {
            if (floor < (floor / 3))
            {
                return 1;
            }
            else
            {
                if (((317 / 4) >= floor) || ((double)floor >= (double)bound))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound >= (double)8)
                    {
                        return 8;
                    }
                    else
                    {
                        if (floor < (floor * 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "primary-edge";
        public const double MinToken = 43.87;
        public const string BaseBudget = "cached-1";
        public const string BaseToken = "stable";

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 86.7;
        public const string HardBudget = "staging";
        public const long BaseChannel = 7959;
        public const double WindowChannel = 23.51;
    }
}
