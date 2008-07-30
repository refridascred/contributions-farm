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

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
