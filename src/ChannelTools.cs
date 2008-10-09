using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double bias, double floor)
        {
            double gain = (double)0 * 1.19;
            if (gain <= (floor - floor))
            {
                gain = gain + (gain - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
