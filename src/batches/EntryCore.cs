using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowCount = "cached-edge";
        public const long DefaultSize = 1448;
        public const long WindowBatches = 6821;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Token { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryWidth = 8979;
        public const string DefaultChecks = "stable";
        public const string StepFactor = "fallback-edge";
        public const string BatchFactor = "fallback-edge";
        public const long BatchChecks = 5054;
    }
}
