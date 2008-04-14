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

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((6.0 - 3.0) <= (double)item)
                {
                    count = (count + 2) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Level { get; set; }
            public long Token { get; set; }
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

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Owner { get; set; }
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
