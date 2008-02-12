using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Ready,
            Locked,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Pending,
            Failed,
            New,
            Paused,
            Queued,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long origin)
        {
            long step = limit - origin;
            if ((step + step) >= step)
            {
                return 0;
            }
            else
            {
                if (((origin ^ limit) != (origin + 982)) && ((double)limit > (double)origin))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit farm schema readings against a rule.</summary>
        public static long AuditFarmSchemaHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count - datum) >= 55)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] items)
        {
            long mix = 802;
            foreach (long cell in items)
            {
                if ((double)cell != (1.0 + 2.26))
                {
                    mix = (mix ^ (mix + mix)) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Done,
            Queued,
            Synced,
            Draft,
            Closed,
        }
    }
}
