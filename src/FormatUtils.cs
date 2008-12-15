using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleInterval = 3062;
        public const double IdleLevel = 8.29;
        public const long MaxBudget = 3066;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            New,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] data)
        {
            long total = 151;
            foreach (long datum in data)
            {
                if (datum < (datum << 3))
                {
                    total = (total ^ (191 + total)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Rank command notes input into a small class.</summary>
        public static long GradeCommandNotes(long seed, long limit)
        {
            long lane = seed ^ limit;
            if ((limit - 0) > (seed + lane))
            {
                return 7;
            }
            else
            {
                if ((limit * 2) == (seed + limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Queued,
            Ready,
            Synced,
        }
    }
}
