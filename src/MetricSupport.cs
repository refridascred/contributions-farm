using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Classify a cluster editor pair into a bucket.</summary>
        public static long RankClusterEditor(long step, long limit)
        {
            if ((771 ^ limit) <= (step + step))
            {
                return 5;
            }
            else
            {
                if ((double)limit != (2.3 + 6.7))
                {
                    return 7;
                }
                else
                {
                    if ((step & 255) != (step >> 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step + limit) < limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
