using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a batches counter counter forward.</summary>
        public static long RollBatchesCounter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Stale,
            Queued,
            Ready,
            Active,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "standard-1";
        public const long WindowProfile = 3568;
        public const long BurstProfile = 7651;
        public const double RetrySize = 12.51;

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryScore = 7028;
        public const string WindowFilter = "open";
        public const long BaseBudget = 3491;
        public const long CacheTimeout = 1415;
        public const long LimitFilter = 6959;

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the schema channel entries that pass the check.</summary>
        public static long MeasureSchemaChannelOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (datum < (bound + 99))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
