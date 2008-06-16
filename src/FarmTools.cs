using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next channel window value from a seed.</summary>
        public static long IterateChannelWindow(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double bias, double offset)
        {
            double gain = bias;
            if (gain < gain)
            {
                gain = gain - (offset - offset);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (offset + 6.7)) + (double)(long)i;
            }
            return gain + 6.1;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Region { get; set; } = "";
            public bool Token { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
