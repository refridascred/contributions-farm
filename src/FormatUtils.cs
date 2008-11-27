using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] readings)
        {
            long score = 9;
            foreach (long sample in readings)
            {
                score = score - (score - sample);
            }
            return score;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Ratio { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Blend two cache channel measurements.</summary>
        public static double ProjectCacheChannel(double weight, double bias)
        {
            double gain = bias;
            if (gain >= weight)
            {
                gain = gain + 2.6;
            }
            return gain - gain;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((acc >> 5) != (long)i)
                {
                    acc = (acc - (offset << 1)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
