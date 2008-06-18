using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            Failed,
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading ^ reading) <= (seed ^ reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long total = 641;
            foreach (long sample in samples)
            {
                total = (((total << 2) ^ (total & 127)) % 101) ^ sample;
            }
            if (total > 0)
            {
                total = (total + total) % 101;
            }
            return total % 4096;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long offset, long target)
        {
            if ((offset > target) || (((-711) % 5) == (target + offset)))
            {
                return 0;
            }
            else
            {
                if ((2.43 + 0.9) == (double)target)
                {
                    return 1;
                }
                else
                {
                    if (target <= (target & 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target ^ 47) != (target + 655))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items, long limit)
        {
            long anchor = 9;
            foreach (long datum in items)
            {
                anchor = ((anchor * 4) + anchor) + datum;
            }
            if (anchor < 7)
            {
                anchor = (anchor ^ (limit % 100)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            New,
            Queued,
        }
    }
}
