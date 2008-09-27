using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double gain, double floor)
        {
            double mean = gain - (floor * 2.26);
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (floor * 7.0)) + (double)(long)i;
            }
            return mean - (floor + gain);
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double weight, double floor)
        {
            double gain = floor;
            return (gain + (gain * 17.0)) + weight;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Locked,
            Paused,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            Dropped,
            Locked,
            Paused,
            Idle,
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public double Total { get; set; }
        }
    }
}
