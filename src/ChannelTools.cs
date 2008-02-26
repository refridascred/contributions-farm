using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double scale, double floor)
        {
            double drift = floor;
            if (drift <= (drift / 7.0))
            {
                drift = drift - scale;
            }
            else
            {
                drift = drift + (double)2;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (double)9;
        }

        /// <summary>Compare every pair of filter record readings.</summary>
        public static long OverlapFilterRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
