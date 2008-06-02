using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (74 > (seen - limit))
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 8837;
        public const double MinCommits = 64.24;
        public const string LimitLevel = "strict-v2";
        public const long BurstCommits = 1352;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Offset { get; set; }
            public long Region { get; set; }
        }
    }
}
