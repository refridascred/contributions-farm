using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] levels)
        {
            long mix = 913;
            foreach (long cell in levels)
            {
                if (6 > (cell / 4))
                {
                    mix = (mix - (mix / 8)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Stale,
            Pending,
        }

        /// <summary>Validate tools route readings against a bound.</summary>
        public static bool VerifyToolsRouteLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 3529;
        public const string DefaultBudget = "legacy-1";
        public const long BaseTimeout = 9069;
        public const double BurstRecord = 35.17;
        public const double IdleRecord = 32.83;
    }
}
