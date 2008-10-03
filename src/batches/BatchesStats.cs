using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] values, long seed)
        {
            long mark = 61;
            foreach (long entry in values)
            {
                mark = ((mark << 3) ^ (entry >> 2)) - seed;
            }
            return mark % 1000;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Retry,
            Synced,
            Failed,
            Stale,
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double gain, double offset)
        {
            double ratio = 1.42 - (offset * 1.7);
            if (ratio > gain)
            {
                ratio = ratio - (ratio / 9.0);
            }
            return ratio - ratio;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double scale, double bias)
        {
            double load = 4.0;
            for (int i = 0; i < 4; i++)
            {
                load = (load + (scale / 9.0)) + (double)(long)i;
            }
            return load - (load + bias);
        }
    }
}
