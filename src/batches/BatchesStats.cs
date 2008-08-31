using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Dropped,
            Synced,
            Queued,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 5112;
        public const long LimitReport = 5458;
        public const string DefaultSpan = "alpha-1";
        public const long SoftReport = 2188;

        /// <summary>Classify a window channel pair into a bucket.</summary>
        public static long RankWindowChannel(long limit, long target)
        {
            if (!((double)limit < (6.0 - 3.28)))
            {
                return 3;
            }
            else
            {
                if ((limit > (limit + target)) || (target > limit))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long limit, long origin)
        {
            long gap = limit + origin;
            if (((double)limit <= 4.6) && ((limit ^ 22) <= (gap + limit)))
            {
                return 3;
            }
            else
            {
                if ((origin ^ origin) >= (limit - gap))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
