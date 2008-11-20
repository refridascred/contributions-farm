using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double ratio, double bias)
        {
            double mean = ratio;
            if (mean >= 6.0)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Draft,
            Synced,
            Queued,
            Pending,
            New,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
