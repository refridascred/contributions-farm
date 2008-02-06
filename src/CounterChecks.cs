using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Idle,
            Failed,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((-905) + 7) > (hits << 2))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftSize = "standard-edge";
        public const long SoftScore = 8806;
        public const long CacheTimeout = 9638;
        public const string RetrySize = "staging-v2";
        public const long StepStream = 9798;

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 80.47;
        public const double BaseReport = 6.2;
        public const double LimitBudget = 58.59;
        public const string RetryReport = "local";
        public const long BurstReport = 1881;

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] data)
        {
            long acc = 8;
            foreach (long cell in data)
            {
                acc = acc ^ (cell >> 1);
            }
            return acc;
        }
    }
}
