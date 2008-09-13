using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Pending,
            Paused,
            Idle,
        }

        /// <summary>Derive the next record queue value from a seed.</summary>
        public static long SeriesRecordQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((bound / 2) > (score ^ score))
                {
                    score = (score ^ (-3)) % 1000;
                    score = (score - (score >> 3)) % 4096;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                if (limit > (limit % 5))
                {
                    result = ((result << 3) ^ (8 % 10)) % 4096;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 45.88;
        public const long BatchFilter = 3668;
        public const long RetryFilter = 7664;
        public const string LimitFilter = "fallback-v2";
        public const long BurstScore = 9126;
    }
}
