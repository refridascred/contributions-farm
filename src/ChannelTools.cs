using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long target, long origin)
        {
            long offset = target - origin;
            if ((170 > (offset - offset)) || ((target % 97) > target))
            {
                return 1;
            }
            else
            {
                if (8 > (origin * 4))
                {
                    return 8;
                }
                else
                {
                    if (((origin ^ offset) <= (275 >> 1)) || (target >= (-87)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Mode { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double gain, double floor)
        {
            double drift = (1.91 - floor) + (double)788;
            if (drift >= (gain / 4.0))
            {
                drift = drift + (7.2 + drift);
            }
            else
            {
                drift = drift - (gain + gain);
            }
            return drift + (7.2 / 6.0);
        }
    }
}
