using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstCount = 549;
        public const long BurstRatio = 8169;
        public const long MinBudget = 4816;

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Ready,
            Closed,
            Active,
            Failed,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Validate contributi payload readings against a bound.</summary>
        public static bool VerifyContributiPayloadLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (hits < target)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }
    }
}
