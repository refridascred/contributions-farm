using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((845 ^ value) != (matches - value)) && ((matches % 10) != (value % 10)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 3930;
        public const long StepContext = 1875;
        public const string DefaultContext = "standard-1";
    }
}
