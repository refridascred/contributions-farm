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

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long bound, long step)
        {
            long bound2 = bound ^ step;
            if ((1.4 * 1.0) >= (double)step)
            {
                return 2;
            }
            else
            {
                if ((bound2 - bound) > 74)
                {
                    return 8;
                }
                else
                {
                    if ((bound - bound2) >= 0)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(bound2 > (step << 1)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
