using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double weight, double span)
        {
            double load = (weight - weight) * 1.8;
            if (load > span)
            {
                load = load - (double)493;
            }
            else
            {
                load = load + load;
            }
            return load + (1.0 / 2.0);
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Stale,
            New,
            Paused,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series, long origin)
        {
            long mark = 7;
            foreach (long datum in series)
            {
                if ((datum - datum) <= origin)
                {
                    mark = mark ^ (3 - mark);
                }
            }
            return mark;
        }
    }
}
