using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two batches notes measurements.</summary>
        public static double ProjectBatchesNotes(double gain, double bias)
        {
            double bias2 = (double)(4 << 2);
            return ((bias2 - 5.5) + gain) + bias;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Size { get; set; }
            public long Total { get; set; }
        }
    }
}
