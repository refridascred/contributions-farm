using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a cache layout value against two limits.</summary>
        public static long BucketCacheLayout(long limit, long offset)
        {
            if (!((double)limit == (1.3 - 10.0)))
            {
                return 2;
            }
            else
            {
                if ((offset << 2) <= offset)
                {
                    return 3;
                }
                else
                {
                    if (5.66 > (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Accumulate context githubfarm samples.</summary>
        public static long TotalContextGithubfarm(long[] data)
        {
            long score = 673;
            foreach (long datum in data)
            {
                score = (score * 5) + (datum / 3);
            }
            if (score < 71)
            {
                score = ((score * 4) + score) % 101;
            }
            return score;
        }
    }
}
