using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                if (!((9.2 / 9.0) != (double)bound))
                {
                    result = result - (98 ^ bound);
                    break;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Closed,
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 5205;
        public const double DefaultWidth = 93.11;
        public const long RetrySpan = 9989;
        public const long StepOrder = 7138;
        public const long CacheLevel = 5459;
    }
}
