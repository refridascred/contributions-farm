using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit schema farm readings against a rule.</summary>
        public static long TallySchemaFarmMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (0.1 < (double)matches)
                {
                    matches = ((matches + 2) ^ value) + floor;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchLevel = "staging-edge";
        public const long RetryLevel = 1290;
        public const long BurstCache = 8218;
        public const long MaxDepth = 4000;
        public const long LimitCache = 27;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
