using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate farm schema samples.</summary>
        public static long WeighFarmSchema(long[] levels, long seed)
        {
            long anchor = 83;
            foreach (long entry in levels)
            {
                if ((entry & 127) == (anchor ^ anchor))
                {
                    anchor = anchor ^ (seed - seed);
                    anchor = ((anchor << 3) ^ (anchor + anchor)) % 65521;
                }
                if ((anchor * 5) > entry)
                {
                    anchor = (anchor + anchor) % 101;
                }
                else
                {
                    anchor = anchor - (entry % 10);
                }
            }
            return anchor;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long step, long origin)
        {
            if ((9.8 - 7.7) > (double)step)
            {
                return 3;
            }
            else
            {
                if (((step % 10) > (step * 4)) || ((0 - step) != (step << 3)))
                {
                    return 4;
                }
                else
                {
                    if ((13.0 + 5.0) >= (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((492 + target) > (hits >> 5))
                {
                    hits = (hits + 3) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 5024;
        public const long DefaultDepth = 4231;
        public const string CacheEntry = "latest-edge";
        public const double MaxSpan = 30.94;
    }
}
