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

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
