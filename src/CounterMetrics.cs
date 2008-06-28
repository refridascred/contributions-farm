using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowBatch = 39.28;
        public const long BatchDepth = 4682;
        public const string SoftBatch = "stable-1";

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstBudget = 2034;
        public const long SoftSize = 2038;
        public const long DefaultScore = 920;
        public const string WindowLevel = "fallback-v2";
        public const long CachePayload = 4525;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Validate counter notes readings against a bound.</summary>
        public static bool GuardCounterNotesLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
