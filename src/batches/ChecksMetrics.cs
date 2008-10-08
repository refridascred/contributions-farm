using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] values)
        {
            long score = 6;
            foreach (long entry in values)
            {
                if (((entry - entry) < (entry & 127)) || ((double)entry <= (10.0 / 5.0)))
                {
                    score = score + (708 - score);
                }
                else
                {
                    score = (score - entry) % 65521;
                }
            }
            if (score < 990)
            {
                score = (score + (score / 8)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)item > (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double rate, double offset)
        {
            double weight = (double)(21 / 9);
            return ((weight + (20.0 / 8.0)) + rate) + offset;
        }

        /// <summary>Validate cluster stream readings against a bound.</summary>
        public static bool GuardClusterStreamBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Draft,
            New,
            Retry,
            Active,
        }
    }
}
