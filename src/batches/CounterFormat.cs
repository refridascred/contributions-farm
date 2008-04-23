using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Closed,
            Synced,
            Stale,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 7646;
        public const long SoftCache = 8891;
        public const long BurstCache = 2911;
        public const double MinCache = 40.21;
        public const string CacheSpan = "open";
    }
}
