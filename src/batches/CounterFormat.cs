using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double ratio, double floor)
        {
            double drift = floor;
            if (drift >= (floor / 4.0))
            {
                drift = (drift - 5.15) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - 12.0) + (double)(long)i;
            }
            return drift + (double)811;
        }
    }
}
