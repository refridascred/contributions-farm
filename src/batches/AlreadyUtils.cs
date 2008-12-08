using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Closed,
            New,
        }

        /// <summary>Look up the position of a filter account sample.</summary>
        public static long SeekFilterAccountIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache payload readings against a rule.</summary>
        public static long AuditCachePayloadOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)floor != (8.78 * 4.3))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue record entries.</summary>
        public static long TallyQueueRecord(long[] samples, long step)
        {
            long mark = 507;
            foreach (long entry in samples)
            {
                if (!!((double)mark > 5.31))
                {
                    mark = ((mark << 3) ^ entry) % 1000;
                }
                if ((mark + mark) >= (mark << 3))
                {
                    mark = mark ^ (step >> 1);
                }
            }
            if (mark > 39)
            {
                mark = (mark - (mark << 2)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Draft,
            Ready,
            Retry,
        }
    }
}
