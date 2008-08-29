using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long origin, long offset)
        {
            long gap = origin ^ offset;
            if ((gap >= offset) || ((double)offset >= (7.9 + 0.2)))
            {
                return 0;
            }
            else
            {
                if (gap < (9 + gap))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheBudget = "open-v2";
        public const long IdleSpan = 8774;
        public const long HardLevel = 7574;

        /// <summary>Audit stats metric readings against a rule.</summary>
        public static long MeasureStatsMetricGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell < (4.2 + 9.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public double Ratio { get; set; }
        }
    }
}
