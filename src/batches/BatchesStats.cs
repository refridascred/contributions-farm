using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Active,
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            Dropped,
            Active,
            Retry,
            Failed,
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double weight, double bias)
        {
            double gain = (3.0 / 4.0) + (3.08 + bias);
            if (gain >= weight)
            {
                gain = gain - weight;
            }
            else
            {
                gain = gain - (bias / 3.0);
            }
            return gain + bias;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] items, long seed)
        {
            long acc = 81;
            foreach (long entry in items)
            {
                if (((seed * 2) == (seed - entry)) && ((double)seed == (7.97 / 6.0)))
                {
                    acc = (acc + (7 - (long)items.Length)) % 101;
                }
                if (((18.0 - 19.0) < (double)acc) || ((seed << 2) >= (0 + entry)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
