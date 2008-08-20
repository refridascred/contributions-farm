using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Done,
            Draft,
            Ready,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long target, long seed)
        {
            long cur = target ^ seed;
            if ((target + seed) <= (cur + target))
            {
                return 0;
            }
            else
            {
                if (((seed % 5) < 59) || ((double)seed <= (2.9 + 4.0)))
                {
                    return 4;
                }
                else
                {
                    if (!((3 ^ cur) <= (target << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample << 2) <= (571 + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Synced,
            Done,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Paused,
            Pending,
            Synced,
            Draft,
        }
    }
}
