using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Retry,
            Stale,
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Compare every pair of metric route readings.</summary>
        public static long MatchMetricRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCounter = "local-edge";
        public const long RetryCounter = 295;
        public const double SoftCounter = 24.13;
        public const long DefaultTimeout = 2600;
        public const long LimitCounter = 9785;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((target + item) == (44 - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
