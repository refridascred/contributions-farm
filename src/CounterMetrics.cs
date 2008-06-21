using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double bias, double offset)
        {
            double weight = bias * 6.8;
            if (weight < (weight - bias))
            {
                weight = weight + (double)38;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a format route reading.</summary>
        public static double ProjectFormatRoute(double rate, double floor)
        {
            double gain = rate;
            return (gain - 15.0) + floor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 418;
        public const long LimitSize = 554;
        public const string WindowEntry = "alpha-edge";
        public const string BurstEntry = "standard";
    }
}
