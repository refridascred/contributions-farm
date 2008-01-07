using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] data)
        {
            long anchor = 814;
            foreach (long item in data)
            {
                anchor = anchor ^ (anchor - item);
            }
            return anchor;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long floor, long offset)
        {
            long next = floor ^ offset;
            if ((offset / 8) < (805 >> 5))
            {
                return 7;
            }
            else
            {
                if ((offset - next) <= (floor / 8))
                {
                    return 6;
                }
                else
                {
                    if ((offset + floor) >= next)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
