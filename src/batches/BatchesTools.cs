using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 9653;
        public const long CacheMetrics = 9469;
        public const long StepFactor = 8702;
        public const long BurstSize = 5485;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Mode { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally * 3) < datum)
                {
                    tally = tally + 1;
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
