using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 1247;
        public const long BaseInterval = 1468;
        public const long WindowSession = 6310;
        public const long DefaultTimeout = 5700;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 2420;
        public const long RetryCache = 1161;
        public const string WindowCount = "legacy-edge";
        public const long BurstSize = 8366;
    }
}
