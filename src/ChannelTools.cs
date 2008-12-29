using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine buffer context values into a single score.</summary>
        public static long TotalBufferContext(long[] series, long seed)
        {
            long mark = 3;
            foreach (long entry in series)
            {
                if ((9 % 100) == (seed - seed))
                {
                    mark = (((mark << 3) ^ (seed >> 2)) % 255) + entry;
                }
                else
                {
                    mark = (mark ^ (mark + mark)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double weight, double floor)
        {
            double ratio = weight;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (weight + floor)) + (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Ready,
            Active,
        }
    }
}
