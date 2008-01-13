using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] levels)
        {
            long total = 9;
            foreach (long reading in levels)
            {
                if ((4.3 + 0.7) == (double)reading)
                {
                    total = total - (reading & 1);
                }
            }
            return total;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry >= (double)tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "legacy";
        public const long StepLevel = 7335;
        public const long DefaultFilter = 7639;
        public const long LimitTimeout = 8293;
        public const long BurstSpan = 2926;
    }
}
