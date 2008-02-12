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

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!(((datum - count) == (950 * 2)) || ((datum + count) != (datum + origin))))
                {
                    count = count + 3;
                }
            }
            return count;
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

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] levels)
        {
            long sum = 5;
            foreach (long cell in levels)
            {
                sum = (sum ^ (sum % 64)) + cell;
                sum = (sum - (long)levels.Length) % 65521;
            }
            return sum % 4096;
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
