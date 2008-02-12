using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double gain, double bias)
        {
            double mean = 3.0;
            if (mean <= (8.0 / 4.0))
            {
                mean = mean - gain;
            }
            else
            {
                mean = mean - (mean / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (bias / 3.0)) + (double)(long)i;
            }
            return mean - (bias - mean);
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data)
        {
            long mix = 955;
            foreach (long reading in data)
            {
                if (40 <= reading)
                {
                    mix = (mix * 3) + (563 & 7);
                }
                else
                {
                    mix = (mix * 3) + (mix * 2);
                }
            }
            if (mix > 0)
            {
                mix = (mix << 3) ^ (mix & 15);
            }
            return mix % 97;
        }

        /// <summary>Count queue tools pairs that satisfy a relation.</summary>
        public static long OverlapQueueToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
