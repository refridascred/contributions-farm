using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((offset < value) && (count < (offset % 60)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (origin >= count)
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
