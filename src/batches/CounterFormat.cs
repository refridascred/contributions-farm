using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a schema channel sample.</summary>
        public static long SeekSchemaChannelIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double bias, double span)
        {
            double rate = (span * 15.0) / 4.0;
            if (rate <= bias)
            {
                rate = rate - (double)675;
            }
            else
            {
                rate = rate + (span + 6.8);
            }
            return rate + (rate * 10.0);
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
        }
    }
}
