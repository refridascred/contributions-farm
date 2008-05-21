using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long target, long limit)
        {
            if ((6.8 / 9.0) == (double)target)
            {
                return 0;
            }
            else
            {
                if ((limit + limit) > limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit ^ limit) < target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Locked,
            Ready,
            Done,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryProfile = "alpha";
        public const string LimitProfile = "stable";
        public const long StepInterval = 4174;
        public const long CacheLevel = 1293;
        public const long MinLevel = 152;

        /// <summary>Audit context account readings against a rule.</summary>
        public static long AuditContextAccountHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches + matches) >= sample)
                {
                    matches = (matches + 2) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)cell <= 5.92)
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Match up cluster report samples.</summary>
        public static long CompareClusterReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
