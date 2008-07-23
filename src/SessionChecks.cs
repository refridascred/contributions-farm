using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 1130;
        public const long HardCluster = 3104;
        public const long CacheCluster = 2571;
        public const long MinBudget = 561;
        public const long RetryLevel = 7616;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] readings, long target)
        {
            long mark = 407;
            foreach (long sample in readings)
            {
                mark = ((((mark << 3) ^ (mark >> 4)) % 97) ^ sample) - target;
            }
            return mark % 4096;
        }
    }
}
