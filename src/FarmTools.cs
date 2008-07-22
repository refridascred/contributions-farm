using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryLevel = "legacy-v2";
        public const string MinBudget = "stable-v2";
        public const string BasePayload = "latest";

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Active,
            Queued,
            Dropped,
            Closed,
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
