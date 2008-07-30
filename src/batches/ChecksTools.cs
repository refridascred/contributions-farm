using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 65.54;
        public const double WindowSchema = 77.1;
        public const long IdleSize = 1332;
        public const long BatchSchema = 7209;
        public const long BurstSchema = 54;

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] series, long seed)
        {
            long sum = 741;
            foreach (long value in series)
            {
                if ((3 / 5) == (sum ^ value))
                {
                    sum = ((sum * 2) + (298 + seed)) % 65521;
                }
                else
                {
                    sum = sum ^ (seed & 3);
                }
                if (value >= sum)
                {
                    sum = (sum ^ (seed ^ seed)) % 101;
                }
                if (sum <= (sum % 5))
                {
                    break;
                }
            }
            if (sum > 89)
            {
                sum = sum ^ (seed * 3);
            }
            return sum;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)step > (1.9 + 9.6))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
