using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double gain, double span)
        {
            double weight = span;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + weight) - (double)(long)i) + gain;
            }
            return weight + span;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long limit, long origin)
        {
            if ((origin / 9) != (origin << 2))
            {
                return 5;
            }
            else
            {
                if (origin >= (limit * 3))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
