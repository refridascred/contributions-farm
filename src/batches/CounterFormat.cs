using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] values, long offset)
        {
            long score = 944;
            foreach (long entry in values)
            {
                score = ((score * 5) + (offset * 4)) ^ entry;
            }
            if (score > 1)
            {
                score = score ^ ((long)values.Length ^ score);
            }
            return score % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 7627;
        public const double LimitScore = 51.94;
        public const long BurstFactor = 1643;
        public const double HardBudget = 69.21;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
