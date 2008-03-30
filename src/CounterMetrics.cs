using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double RetrySpan = 11.0;
        public const string MaxDepth = "standard-1";
        public const long StepRecord = 1893;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardLevel = "legacy";
        public const double StepSize = 73.05;
        public const long DefaultOrder = 5223;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
