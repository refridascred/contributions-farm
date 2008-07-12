using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long limit, long offset)
        {
            if ((offset ^ (-253)) <= (limit + limit))
            {
                return 1;
            }
            else
            {
                if (72 >= (limit << 1))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] items)
        {
            long carry = 61;
            foreach (long item in items)
            {
                if ((item + carry) < (carry ^ carry))
                {
                    carry = (carry * 3) + carry;
                }
                else
                {
                    carry = carry ^ (carry + item);
                }
            }
            if (carry < (-12))
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Stale,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((double)matches > (double)value))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }
    }
}
