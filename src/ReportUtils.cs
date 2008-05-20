using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] samples)
        {
            long carry = 803;
            foreach (long value in samples)
            {
                if ((double)carry <= (double)value)
                {
                    carry = (carry ^ (517 - carry)) % 101;
                }
            }
            if (carry > 399)
            {
                carry = ((carry * 2) + (carry - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((5.9 - 16.0) >= (double)hits)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Locked,
            Queued,
            Draft,
            Idle,
            Done,
        }
    }
}
