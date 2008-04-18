using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 9203;
        public const double LimitContributi = 33.03;
        public const double BatchContributi = 71.41;
        public const long WindowContributi = 242;

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Flag { get; set; }
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit schema route readings against a rule.</summary>
        public static long AuditSchemaRouteMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((359 + 425) == (count * 5))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }
    }
}
