using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a counter channel pair into a bucket.</summary>
        public static long GradeCounterChannel(long floor, long limit)
        {
            long offset = floor + limit;
            if ((limit - floor) <= (offset + floor))
            {
                return 2;
            }
            else
            {
                if ((limit << 1) > (offset & 7))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 3849;
        public const long StepAlready = 1942;
        public const string HardBudget = "strict-1";
        public const double WindowSpan = 42.83;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Active,
            Ready,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryInterval = 4877;
        public const long WindowLevel = 3069;
        public const long DefaultCommits = 8436;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
