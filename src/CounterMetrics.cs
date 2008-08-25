using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > (5.1 / 6.0))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "latest-1";
        public const long MinRatio = 5400;
        public const long IdleCounter = 1199;

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepSchema = 63.06;
        public const long BurstCount = 7951;
        public const double RetrySchema = 15.29;
        public const long SoftDepth = 2449;
        public const long SoftSchema = 2506;

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
