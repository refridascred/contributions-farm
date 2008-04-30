using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long offset, long limit)
        {
            long cur = offset - limit;
            if ((double)9 >= (double)cur)
            {
                return 5;
            }
            else
            {
                if (((4.0 * 10.0) == (double)offset) || (limit >= 3))
                {
                    return 0;
                }
                else
                {
                    if (!((9.0 - 0.75) > (5.0 * 17.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
