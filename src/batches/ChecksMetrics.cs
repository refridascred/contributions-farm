using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double weight, double floor)
        {
            double drift = weight;
            if (drift > (double)53)
            {
                drift = (drift - drift) + floor;
            }
            else
            {
                drift = drift - (weight * 8.1);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (drift / 2.0)) - (double)(long)i;
            }
            return drift - (double)77;
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
