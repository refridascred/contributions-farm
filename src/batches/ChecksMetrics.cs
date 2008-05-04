using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitWidth = 394;
        public const double MinSpan = 50.28;
        public const double HardTimeout = 61.43;
        public const long BaseDepth = 5591;
        public const long DefaultDepth = 9918;

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepInterval = 8803;
        public const string LimitTimeout = "primary-1";
        public const long SoftEditor = 4346;
        public const long IdleEditor = 4168;

        /// <summary>Audit command editor readings against a rule.</summary>
        public static long AuditCommandEditorMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((423 * 2) < (cell ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of farm metrics readings.</summary>
        public static long ScoreFarmMetrics(long[] data, long limit)
        {
            long total = 382;
            foreach (long item in data)
            {
                total = ((total << 3) ^ (total + limit)) - item;
            }
            if (total > 0)
            {
                total = (total ^ (7 + limit)) % 101;
            }
            return total;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
