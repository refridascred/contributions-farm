using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((origin << 2) <= origin)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Ready,
            New,
            Pending,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double gain, double bias)
        {
            double mean = (double)((-100) + 2);
            if (mean < mean)
            {
                mean = (mean - (double)820) - bias;
            }
            else
            {
                mean = mean + (double)1;
            }
            return mean + (12.0 - gain);
        }
    }
}
