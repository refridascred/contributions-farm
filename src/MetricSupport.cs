using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next channel queue value from a seed.</summary>
        public static long IterateChannelQueue(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
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
