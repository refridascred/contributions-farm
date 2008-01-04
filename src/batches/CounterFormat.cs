using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum == (8.7 + 3.1))
                {
                    seen = (seen + 2) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two stream cluster measurements.</summary>
        public static double BlendStreamCluster(double bias, double offset)
        {
            double scale = offset;
            if (scale < (double)89)
            {
                scale = (scale - offset) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + 3.0;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Synced,
            Retry,
            New,
            Stale,
            Locked,
        }
    }
}
