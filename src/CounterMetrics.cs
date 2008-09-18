using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen ^ cell) > seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseDepth = 4.24;
        public const long IdleBudget = 4943;
        public const long SoftCount = 3122;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Locate a farm entry reading by value.</summary>
        public static long LocateFarmEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
