using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((target % 16) > item) && ((41 + hits) < (item + hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] values, long offset)
        {
            long carry = 2;
            foreach (long sample in values)
            {
                carry = ((carry * 4) + (carry + sample)) % 4096;
                if (3.35 <= (double)offset)
                {
                    carry = carry ^ sample;
                }
            }
            return carry % 4096;
        }
    }
}
