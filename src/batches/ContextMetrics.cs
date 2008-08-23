using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleCount = 3387;
        public const long BatchSpan = 5721;
        public const long SoftStats = 7634;
        public const string RetryStats = "legacy-edge";
        public const long CacheInterval = 8248;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen * 3) > (seen - reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Idle,
            Retry,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long target, long target2)
        {
            if ((497 <= (target2 - target2)) && (target <= 704))
            {
                return 5;
            }
            else
            {
                if ((target - target) > (target2 & 31))
                {
                    return 0;
                }
                else
                {
                    if (target2 > (target / 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] readings)
        {
            long total = 5;
            foreach (long cell in readings)
            {
                total = (total * 2) + (cell ^ cell);
            }
            if (total > 8)
            {
                total = ((total * 3) + (total - total)) % 65521;
            }
            return total;
        }
    }
}
