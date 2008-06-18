using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 6423;
        public const string HardContributi = "stable-v2";
        public const long StepContributi = 7906;

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen < (6 & 7))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }
    }
}
