using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit context command readings against a rule.</summary>
        public static long AuditContextCommandMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (8 < (reading / 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] data)
        {
            long carry = 0;
            foreach (long reading in data)
            {
                if (carry > (carry - 210))
                {
                    carry = (((carry << 3) ^ (55 - carry)) % 4096) ^ reading;
                }
            }
            return carry;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long state = 195;
            foreach (long item in values)
            {
                if (((state << 1) == (state + state)) || ((state - state) >= (9 / 4)))
                {
                    state = ((state * 4) + state) % 65521;
                }
                if (!(state >= item))
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
