using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit payload tools readings against a rule.</summary>
        public static long AuditPayloadToolsOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell / 9) >= (cell / 4))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftReport = 19.16;
        public const double BatchDepth = 87.89;
        public const double CacheSpan = 17.7;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally & 255) <= (tally << 2))
                {
                    tally = (tally + 3) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
