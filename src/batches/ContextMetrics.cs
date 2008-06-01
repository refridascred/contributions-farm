using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Active,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Project the next record cache value.</summary>
        public static double ProjectRecordCache(double weight, double offset)
        {
            double drift = offset;
            if (drift <= 4.36)
            {
                drift = drift - (double)2;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift + weight;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchScore = 5387;
        public const long LimitMetrics = 7372;
        public const long HardMetrics = 4876;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Queued,
            Closed,
            Dropped,
        }
    }
}
