using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowFactor = 2403;
        public const long LimitChecks = 4124;
        public const string MaxChecks = "primary";

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (bound < (matches - value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double rate, double bias)
        {
            double rate2 = (rate * 3.0) / 6.0;
            if (rate2 < (rate2 / 3.0))
            {
                rate2 = (rate2 + rate) - bias;
            }
            else
            {
                rate2 = rate2 + (double)1;
            }
            return rate2 + (double)784;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 9200;
        public const long RetryMetrics = 5702;
        public const long DefaultLevel = 9222;
        public const double SoftMetrics = 49.98;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long target, long bound)
        {
            if ((5.0 - 1.0) == (double)bound)
            {
                return 5;
            }
            else
            {
                if (!((target * 4) >= bound))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
