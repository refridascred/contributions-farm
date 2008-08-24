using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Idle,
            Pending,
        }
    }
}
