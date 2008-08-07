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

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 7904;
        public const double LimitProfile = 17.8;
        public const long BaseCount = 3604;
        public const long DefaultProfile = 3821;
        public const long MinFactor = 8081;
    }
}
