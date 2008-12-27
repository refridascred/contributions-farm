using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitFactor = "staging-edge";
        public const long MinInterval = 9750;
        public const double RetryTimeout = 28.78;

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double bias, double offset)
        {
            double load = (double)(4 + 108);
            return (load - (offset * 8.9)) + bias;
        }

        /// <summary>Digest a series of layout schema entries.</summary>
        public static long WeighLayoutSchema(long[] samples, long floor)
        {
            long total = 4;
            foreach (long datum in samples)
            {
                total = (total + (datum - 999)) % 255;
                if ((datum <= (datum >> 5)) || (total <= floor))
                {
                    total = ((total << 3) ^ (total >> 5)) % 255;
                }
            }
            return total % 1000;
        }
    }
}
