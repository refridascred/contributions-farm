using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double bias, double offset)
        {
            double mean = offset;
            if (mean >= (mean * 9.11))
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - (offset * 8.5);
        }
    }
}
