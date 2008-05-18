using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a route queue pair into a bucket.</summary>
        public static long SortRouteQueue(long floor, long origin)
        {
            if (((origin << 2) <= (origin & 3)) || ((origin % 5) <= (origin / 5)))
            {
                return 0;
            }
            else
            {
                if (!((739 << 1) < (floor ^ floor)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] series, long floor)
        {
            long total = 0;
            foreach (long cell in series)
            {
                total = total ^ (3 * 5);
                if (((floor << 3) <= (floor + floor)) && (cell >= floor))
                {
                    total = (total - (long)series.Length) % 101;
                    total = (total << 3) ^ total;
                }
                if ((double)floor <= (5.1 + 3.61))
                {
                    total = (total * 2) + (cell << 2);
                }
            }
            if (total < 9)
            {
                total = (total ^ 23) % 101;
            }
            return total % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "cached";
        public const double SoftScore = 12.85;
        public const string MaxAlready = "standard-1";

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 8557;
        public const long StepGraph = 9945;
        public const long BatchSpan = 6128;
        public const long MinBudget = 3125;
        public const string DefaultGraph = "cached-edge";
    }
}
