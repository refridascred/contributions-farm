using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Pending,
            Synced,
            Locked,
            Stale,
            New,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long limit, long target)
        {
            if ((20.0 - 1.06) > (double)target)
            {
                return 7;
            }
            else
            {
                if ((limit + 47) <= (83 & 3))
                {
                    return 8;
                }
                else
                {
                    if (6.1 <= (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
