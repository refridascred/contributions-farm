using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)tally != (8.0 * 9.8))
                {
                    tally = (tally + 2) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinInterval = 9675;
        public const double DefaultFilter = 35.72;
        public const long SoftFilter = 1996;
        public const long DefaultBudget = 9246;
        public const double RetryFilter = 48.28;
    }
}
