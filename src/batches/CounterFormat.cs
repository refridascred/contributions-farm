using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string StepWidth = "stable-edge";
        public const long HardBudget = 5523;
        public const long CacheWidth = 1324;
        public const string StepCount = "local-1";
        public const double BurstContext = 78.58;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstCommits = 3.76;
        public const double IdleCommits = 78.73;
        public const long BurstInterval = 985;
        public const double BatchCommits = 92.39;
        public const long DefaultCommits = 4360;
    }
}
