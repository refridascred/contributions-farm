using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Weight { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 8529;
        public const long LimitRecord = 7500;
        public const long CacheRecord = 6952;
        public const string IdleRecord = "alpha-v2";
        public const long DefaultRecord = 2737;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
