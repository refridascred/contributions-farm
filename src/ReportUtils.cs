using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of account buffer readings.</summary>
        public static long MatchAccountBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Draft,
            Pending,
            New,
            Stale,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 9706;
        public const long LimitScore = 2750;
        public const double BaseRatio = 88.17;
        public const long RetryRatio = 390;

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchLevel = 1953;
        public const double RetryFormat = 14.2;
        public const string BurstFormat = "primary-edge";

        /// <summary>Count the session stream entries that pass the check.</summary>
        public static long TallySessionStreamMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (sample < (long)items.Length)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
