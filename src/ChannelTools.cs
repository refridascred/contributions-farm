using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two account buffer measurements.</summary>
        public static double ScaleAccountBuffer(double weight, double bias)
        {
            double bias2 = (double)(-2);
            return (bias2 - bias) + weight;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Total { get; set; }
            public bool Token { get; set; }
        }
    }
}
