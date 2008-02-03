using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleDepth = 9015;
        public const long StepStream = 722;
        public const long BaseScore = 1874;
        public const long BatchWidth = 48;

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
