using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheScore = 1.19;
        public const long MaxWindow = 1614;
        public const long WindowSize = 6444;
        public const string BurstDepth = "strict-edge";
        public const long IdleLevel = 9327;

        /// <summary>Validate support buffer readings against a bound.</summary>
        public static bool GuardSupportBufferBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (target > (64 - 9))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
