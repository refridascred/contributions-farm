using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSpan = 5785;
        public const string IdleBudget = "staging-1";
        public const string DefaultWidth = "alpha-edge";
        public const long SoftBudget = 5668;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value != (double)seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
