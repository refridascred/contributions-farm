using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 1378;
        public const long StepCommits = 6105;
        public const long SoftRatio = 8851;
        public const long BatchCommits = 8120;
        public const long CacheCommits = 6541;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 3709;
        public const long MinScore = 1001;
        public const long HardCount = 975;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            Idle,
            Pending,
        }
    }
}
