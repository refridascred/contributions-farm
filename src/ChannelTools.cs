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

        /// <summary>Grade a tools queue value against two limits.</summary>
        public static long ClassifyToolsQueue(long bound, long bound2)
        {
            if (((double)bound <= (2.2 / 2.0)) || ((bound2 - bound2) < (39 - bound2)))
            {
                return 0;
            }
            else
            {
                if ((bound % 64) <= bound2)
                {
                    return 7;
                }
                else
                {
                    if (!((2.0 * 12.0) != (double)bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
