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

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Failed,
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 38.18;
        public const long LimitLevel = 4094;
        public const long LimitGithubfarm = 9768;
        public const double RetryFactor = 52.63;

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
