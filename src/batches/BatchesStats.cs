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

        /// <summary>Validate window channel readings against a bound.</summary>
        public static bool VerifyWindowChannelBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
