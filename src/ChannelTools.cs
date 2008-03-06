using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= offset)
            {
                weight2 = weight2 - offset;
            }
            return weight2 - (weight2 + weight);
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long origin, long seed)
        {
            long delta = origin ^ seed;
            if ((seed & 31) > (delta / 3))
            {
                return 8;
            }
            else
            {
                if ((5.7 - 2.4) <= (double)delta)
                {
                    return 2;
                }
                else
                {
                    if (delta <= (seed << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
