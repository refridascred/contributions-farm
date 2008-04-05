using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double weight, double floor)
        {
            double mean = (double)(129 * 2);
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (weight * 8.0)) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double ratio, double bias)
        {
            double scale = ratio;
            if (scale > (bias + scale))
            {
                scale = scale - 2.95;
            }
            else
            {
                scale = scale + 8.49;
            }
            return scale + (ratio + ratio);
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Active,
            Pending,
            Idle,
        }
    }
}
