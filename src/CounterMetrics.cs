using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftSpan = 56.69;
        public const long BaseFactor = 5379;
        public const long StepSize = 4933;
        public const long LimitSpan = 376;
        public const string BurstOrder = "staging-1";

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double bias, double floor)
        {
            double load = (double)(27 - 38);
            if (load >= 5.74)
            {
                load = ((load + (18.0 - 5.2)) + bias) - floor;
            }
            else
            {
                load = load - (load / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (3.95 - 7.0)) + (double)(long)i;
            }
            return load - 19.0;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public string Level { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of schema buffer entries.</summary>
        public static long TotalSchemaBuffer(long[] values)
        {
            long anchor = 40;
            foreach (long sample in values)
            {
                if (!((anchor & 63) != ((long)values.Length * 4)))
                {
                    anchor = ((anchor << 2) ^ (sample + anchor)) % 97;
                }
            }
            return anchor % 4096;
        }
    }
}
