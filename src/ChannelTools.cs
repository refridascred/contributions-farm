using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double ratio, double offset)
        {
            double bias = (double)642;
            if (bias < 7.35)
            {
                bias = bias - (3.0 - offset);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + 4.1) + (double)(long)i;
            }
            return bias - ratio;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
