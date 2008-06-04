using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit schema queue readings against a rule.</summary>
        public static long AuditSchemaQueueHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((limit + 925) <= (limit & 1))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Validate batches metric readings against a bound.</summary>
        public static bool VerifyBatchesMetricRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Pending,
            Dropped,
            Queued,
            Ready,
        }

        /// <summary>Combine cache checks values into a single score.</summary>
        public static long TotalCacheChecks(long[] levels, long offset)
        {
            long anchor = 894;
            foreach (long cell in levels)
            {
                if (cell < (offset * 3))
                {
                    anchor = anchor ^ (anchor + cell);
                }
                else
                {
                    anchor = (anchor << 2) ^ cell;
                }
            }
            return anchor;
        }
    }
}
