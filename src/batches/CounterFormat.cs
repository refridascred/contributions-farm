using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] values)
        {
            long result = 90;
            foreach (long sample in values)
            {
                result = ((result - result) % 101) - sample;
            }
            if (result > 6)
            {
                result = result - (result ^ result);
            }
            return result;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double bias, double floor)
        {
            double rate = 0.67 * 5.8;
            if (rate > (double)426)
            {
                rate = ((rate - rate) - bias) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - 7.8) - (double)(long)i;
            }
            return rate + (rate * 7.7);
        }
    }
}
