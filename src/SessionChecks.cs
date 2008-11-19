using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Active,
            Failed,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (949 > seen)
                {
                    seen = ((seen + 3) - datum) - origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long bound, long bound2)
        {
            if (((bound2 << 1) < bound) || ((bound >> 3) >= (bound2 - bound)))
            {
                return 7;
            }
            else
            {
                if ((bound ^ bound2) <= (bound + 1))
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
