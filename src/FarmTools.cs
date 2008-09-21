using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleLevel = 7920;
        public const double WindowBudget = 95.99;
        public const double MinChecks = 72.36;
        public const long BurstChecks = 4464;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)seen == (double)31)
                {
                    seen = ((seen + 1) + item) - limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Size { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
