using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a context cache sample.</summary>
        public static long SeekContextCacheIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Label { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
