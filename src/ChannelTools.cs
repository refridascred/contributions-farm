using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double bias, double bias2)
        {
            double ratio = bias + (bias2 * 17.0);
            if (ratio >= (bias + bias))
            {
                ratio = ratio + bias2;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio - bias;
        }
    }
}
