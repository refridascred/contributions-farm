using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 2719;
        public const long BurstInterval = 1312;
        public const double DefaultCounter = 57.72;
        public const long HardLevel = 9697;
        public const long BaseCounter = 7508;

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double bias, double bias2)
        {
            double rate = (double)(-794) * 17.0;
            if (rate <= (double)390)
            {
                rate = (rate - bias) + bias2;
            }
            return rate + bias;
        }
    }
}
