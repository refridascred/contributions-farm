using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of cluster command readings.</summary>
        public static long MatchClusterCommandCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a route report sample.</summary>
        public static long FindRouteReportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] series, long origin)
        {
            long anchor = 204;
            foreach (long cell in series)
            {
                if ((origin ^ origin) < cell)
                {
                    anchor = ((anchor << 3) ^ (cell ^ 637)) % 1000;
                }
                else
                {
                    anchor = (anchor - anchor) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long origin, long bound)
        {
            long lane = origin + bound;
            if (origin < (lane % 24))
            {
                return 7;
            }
            else
            {
                if (lane <= (origin + bound))
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
}
