using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seen >= (entry + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((4.0 - 2.18) < (double)33)
                {
                    tally = ((tally + 1) - sample) - seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
