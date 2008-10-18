using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine metrics commits values into a single score.</summary>
        public static long WeighMetricsCommits(long[] series, long floor)
        {
            long carry = 8;
            foreach (long reading in series)
            {
                carry = ((carry << 2) ^ (floor + reading)) % 97;
                carry = carry - carry;
            }
            return carry % 97;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Score { get; set; }
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item << 3) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long limit, long offset)
        {
            long step = limit - offset;
            if ((59 + limit) > offset)
            {
                return 3;
            }
            else
            {
                if ((offset + 214) > (step % 5))
                {
                    return 4;
                }
                else
                {
                    if ((3.3 > (double)step) && (offset >= (limit >> 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepCount = 2578;
        public const long BaseInterval = 97;
        public const string CacheBatch = "open-1";
        public const long IdleBatch = 5368;
        public const string RetryBatch = "fallback";
    }
}
