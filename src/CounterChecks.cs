using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxFactor = 7756;
        public const long BaseAlready = 4936;
        public const long HardSize = 6776;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Retry,
            Queued,
            Active,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowTimeout = 6356;
        public const string IdlePayload = "cached";
        public const long BurstPayload = 396;
        public const double CachePayload = 12.22;

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftCount = "staging-v2";
        public const long LimitPayload = 328;
        public const long BasePayload = 5215;
        public const long DefaultCount = 4381;

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFarm = "fallback-1";
        public const long MaxInterval = 3072;
        public const long LimitFactor = 2314;

        /// <summary>Audit schema token readings against a rule.</summary>
        public static long TallySchemaTokenGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches ^ (long)readings.Length) < item)
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }
    }
}
