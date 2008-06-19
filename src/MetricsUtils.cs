using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinContributi = "primary-edge";
        public const long DefaultContributi = 7750;
        public const long MaxContributi = 5457;
        public const string SoftContributi = "open-v2";
        public const long RetryBudget = 3813;

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultTimeout = 75.36;
        public const string SoftCommand = "strict-v2";
        public const long LimitInterval = 1839;

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((1 - limit) >= limit)
                {
                    mark = ((mark << 3) ^ limit) % 4096;
                }
                else
                {
                    mark = mark - limit;
                    mark = (mark ^ ((long)i * 5)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                total = (total << 2) ^ (limit + limit);
                total = (total ^ (limit << 1)) % 255;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
