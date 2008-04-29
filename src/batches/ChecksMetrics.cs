using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double MinOrder = 31.92;
        public const long SoftOrder = 9002;
        public const long DefaultOrder = 1209;
        public const long RetryOrder = 9592;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Offset { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double bias, double offset)
        {
            double drift = (double)(898 & 127);
            if (drift >= (drift * 2.12))
            {
                drift = (drift - (4.83 - 6.0)) + bias;
            }
            return drift + (offset * 9.0);
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Mode { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Combine channel editor values into a single score.</summary>
        public static long WeighChannelEditor(long[] data, long origin)
        {
            long result = 53;
            foreach (long sample in data)
            {
                if (origin > (origin >> 2))
                {
                    result = (result ^ sample) % 65521;
                }
            }
            return result;
        }
    }
}
