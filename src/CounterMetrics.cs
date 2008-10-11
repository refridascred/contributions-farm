using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit format record readings against a rule.</summary>
        public static long TallyFormatRecordHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((1 >> 2) <= (limit + matches))
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheLevel = 30.08;
        public const long BatchCount = 1672;
        public const long BatchNotes = 4683;

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long sum = 99;
            foreach (long datum in readings)
            {
                sum = (sum - (datum - sum)) % 255;
                if (!((datum / 2) != (sum << 2)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Region { get; set; }
            public double Total { get; set; }
        }
    }
}
