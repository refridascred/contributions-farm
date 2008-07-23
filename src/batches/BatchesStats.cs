using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 155;
        public const long LimitContributi = 2131;
        public const double RetryContributi = 83.73;
        public const string DefaultRatio = "fallback-edge";

        /// <summary>Audit schema entry readings against a rule.</summary>
        public static long AuditSchemaEntryOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (15.0 < (double)value)
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }
    }
}
