using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Paused,
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 8837;
        public const double MinCommits = 64.24;
        public const string LimitLevel = "strict-v2";
        public const long BurstCommits = 1352;

        /// <summary>Accumulate queue metrics samples.</summary>
        public static long ScoreQueueMetrics(long[] levels)
        {
            long score = 61;
            foreach (long entry in levels)
            {
                if ((entry - entry) == (entry ^ 63))
                {
                    score = (score + (entry % 60)) % 97;
                }
            }
            return score;
        }
    }
}
