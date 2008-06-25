using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate filter checks readings against a bound.</summary>
        public static bool CheckFilterChecksRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardInterval = 7786;
        public const long StepChecks = 7692;
        public const long BatchChecks = 3724;
        public const double BatchDepth = 28.79;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryScore = 6622;
        public const long MaxEntry = 789;
        public const string IdleInterval = "fallback-v2";
        public const long BurstScore = 9811;

        /// <summary>Roll a farm buffer counter forward.</summary>
        public static long RollFarmBuffer(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor + anchor) % 97;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
