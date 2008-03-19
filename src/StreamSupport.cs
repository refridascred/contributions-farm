using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Size { get; set; }
            public string Score { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Find the first stats queue entry that matches the target.</summary>
        public static long SeekStatsQueueIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a token record figure with a bias.</summary>
        public static double SmoothTokenRecord(double bias, double offset)
        {
            double ratio = (double)(47 - 479);
            if (ratio > 5.3)
            {
                ratio = (ratio + (double)2) + bias;
            }
            return ratio - (offset + offset);
        }
    }
}
