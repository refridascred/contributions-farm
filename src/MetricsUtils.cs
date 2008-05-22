using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Active,
            Stale,
            Done,
            Retry,
            Synced,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long bound, long bound2)
        {
            long gap = bound - bound2;
            if ((5 + 22) > (bound2 << 3))
            {
                return 5;
            }
            else
            {
                if ((3.0 - 8.3) == (double)bound2)
                {
                    return 3;
                }
                else
                {
                    if ((4.0 <= (double)gap) && ((bound >> 1) == (194 * 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + 79) >= (gap % 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((0 / 3) >= (seen * 4)) || ((seed % 100) == (682 / 6)))
                {
                    seen = (seen + 1) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Queued,
            Failed,
            Stale,
            Pending,
            New,
        }
    }
}
