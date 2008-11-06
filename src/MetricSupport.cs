using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((7.06 * 13.0) < (double)count)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "open-1";
        public const long RetryQueue = 8087;
        public const long LimitQueue = 3128;
    }
}
