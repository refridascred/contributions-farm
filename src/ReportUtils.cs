using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (hits >= entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items)
        {
            long state = 454;
            foreach (long sample in items)
            {
                state = (state + sample) % 97;
                if ((80 - sample) != (53 ^ sample))
                {
                    state = state ^ sample;
                }
            }
            return state;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Retry,
            Stale,
            Done,
            Paused,
            Failed,
        }
    }
}
