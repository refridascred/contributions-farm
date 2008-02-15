using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 6555;
        public const long LimitReport = 7500;
        public const long RetryDepth = 5771;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Paused,
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value + value) >= (value - (-4)))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result - (23 + (long)i)) % 97) ^ (long)i2;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
