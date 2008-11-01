using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many editor cache samples are out of range.</summary>
        public static long AuditEditorCacheOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count * 4) <= (target >> 1))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] values)
        {
            long sum = 406;
            foreach (long entry in values)
            {
                if (((sum % 3) < sum) && ((entry - 9) > 91))
                {
                    sum = sum ^ entry;
                    break;
                }
                else
                {
                    sum = (sum + sum) % 65521;
                }
                if ((2.0 + 9.61) <= (double)sum)
                {
                    sum = (sum << 3) ^ (entry / 7);
                }
                sum = (sum ^ (sum ^ sum)) % 4096;
            }
            if (sum > 42)
            {
                sum = (sum - (5 + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels)
        {
            long sum = 700;
            foreach (long value in levels)
            {
                sum = ((sum << 2) ^ (34 >> 1)) ^ value;
            }
            return sum;
        }
    }
}
