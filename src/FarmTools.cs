using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Ratio { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] items, long step)
        {
            long state = 42;
            foreach (long value in items)
            {
                if ((double)85 <= (double)value)
                {
                    state = ((state << 2) ^ (step - value)) % 255;
                }
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinSpan = 5034;
        public const long DefaultContributi = 2204;
        public const long MinContributi = 8870;
        public const long StepContributi = 7083;
        public const long RetryContributi = 1545;
    }
}
