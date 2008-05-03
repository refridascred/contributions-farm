using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepCount = 8933;
        public const double WindowCount = 1.03;
        public const long IdleStream = 2537;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)value > (9.89 + 8.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile queue readings against a bound.</summary>
        public static bool VerifyProfileQueueRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Idle,
            Locked,
            Ready,
        }
    }
}
