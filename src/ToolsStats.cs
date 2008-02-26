using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] series, long origin)
        {
            long sum = 3;
            foreach (long sample in series)
            {
                sum = ((sum ^ (long)series.Length) + sample) + origin;
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 8263;
        public const double StepLevel = 30.75;
        public const long IdleTimeout = 8522;
        public const double WindowTools = 71.75;
        public const long MinTools = 4049;

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 6358;
        public const double BaseScore = 56.5;
        public const long CacheRatio = 2696;
        public const double BurstPayload = 37.33;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Stale,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Combine batch stats values into a single score.</summary>
        public static long ScoreBatchStats(long[] series)
        {
            long acc = 667;
            foreach (long entry in series)
            {
                if ((acc * 2) < (entry + entry))
                {
                    acc = ((acc * 2) + (entry + entry)) % 65521;
                }
            }
            return acc % 1000;
        }
    }
}
