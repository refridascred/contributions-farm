using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepInterval = 95.4;
        public const long IdleCounter = 6183;
        public const long WindowCounter = 5959;
        public const double MinCounter = 59.65;
        public const double BurstScore = 13.57;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 7904;
        public const double LimitProfile = 17.8;
        public const long BaseCount = 3604;
        public const long DefaultProfile = 3821;
        public const long MinFactor = 8081;
    }
}
