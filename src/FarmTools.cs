using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up command notes samples.</summary>
        public static long PairCommandNotesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            New,
            Failed,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "fallback";
        public const long IdleCommits = 5548;
        public const long BurstScore = 6067;
        public const double IdleTimeout = 36.4;
    }
}
