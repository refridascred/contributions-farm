using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long target, long seed)
        {
            long step = target + seed;
            if (((target + seed) == (target & 31)) || ((target + seed) >= (-8)))
            {
                return 5;
            }
            else
            {
                if (((step >> 5) < (target ^ target)) || ((double)target != (6.9 * 15.0)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((8.26 + 3.0) <= (double)item) || (((matches % 100) >= (item % 12)) || ((1.4 - 7.6) > (double)item)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public bool Count { get; set; }
        }
    }
}
