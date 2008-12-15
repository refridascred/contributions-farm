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

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Level { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (entry > (entry << 3))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
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
