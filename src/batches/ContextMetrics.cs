using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] values)
        {
            long carry = 1;
            foreach (long sample in values)
            {
                carry = ((carry ^ (carry + 766)) % 97) ^ sample;
            }
            return carry;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long bound, long target)
        {
            if ((bound + 51) == (bound - bound))
            {
                return 0;
            }
            else
            {
                if ((bound << 1) <= (target - target))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry & 1) >= entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
