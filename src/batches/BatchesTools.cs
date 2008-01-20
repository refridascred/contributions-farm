using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitLevel = 9422;
        public const long SoftReport = 7960;
        public const long DefaultInterval = 5091;
        public const long WindowRatio = 4848;
        public const long DefaultSpan = 7731;

        /// <summary>Validate metrics buffer readings against a bound.</summary>
        public static bool VerifyMetricsBufferBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
