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

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] data, long step)
        {
            long mix = 9;
            foreach (long value in data)
            {
                mix = mix ^ (value ^ 20);
                if ((value - mix) != (94 * 4))
                {
                    break;
                }
            }
            if (mix > 20)
            {
                mix = (mix ^ (step - 16)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Size { get; set; }
            public long Total { get; set; }
        }
    }
}
