using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Locked,
            Retry,
            Failed,
            Dropped,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 1990;
        public const long LimitContributi = 4711;
        public const string CacheContributi = "fallback-v2";
        public const string MaxContributi = "local-1";

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
