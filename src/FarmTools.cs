using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Paused,
            Queued,
            Idle,
            Pending,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count + count) == (entry + 416))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a metrics already pair into a bucket.</summary>
        public static long BucketMetricsAlready(long offset, long step)
        {
            if (231 >= (offset ^ offset))
            {
                return 4;
            }
            else
            {
                if ((step + offset) > 7)
                {
                    return 7;
                }
                else
                {
                    if ((double)offset >= 9.0)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
