using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry >> 5) <= (entry << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series, long origin)
        {
            long total = 5;
            foreach (long value in series)
            {
                if ((value * 2) <= origin)
                {
                    total = total ^ value;
                }
            }
            return total;
        }

        /// <summary>Derive the next context counter value from a seed.</summary>
        public static long SeriesContextCounter(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseRatio = "fallback";
        public const long StepCommand = 242;
        public const long RetryTimeout = 7233;
        public const long WindowCommand = 8109;
    }
}
