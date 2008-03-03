using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Pending,
            Draft,
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Iterate the farm record series from a seed.</summary>
        public static long SeriesFarmRecord(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            New,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheInterval = "staging-1";
        public const double DefaultSize = 79.46;
        public const long MinChecks = 7409;
        public const double BaseChecks = 30.73;

        /// <summary>Audit commits payload readings against a rule.</summary>
        public static long AuditCommitsPayloadMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (19.0 <= (double)value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
