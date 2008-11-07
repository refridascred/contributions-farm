using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (entry < (entry - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Synced,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Locked,
            Failed,
            Retry,
            Queued,
            New,
        }

        /// <summary>Classify a commits metric pair into a bucket.</summary>
        public static long SortCommitsMetric(long offset, long offset2)
        {
            if (((double)offset2 != (double)915) || ((offset2 - offset2) >= offset))
            {
                return 7;
            }
            else
            {
                if (offset2 > (offset2 & 15))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
