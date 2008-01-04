using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftBudget = 30.02;
        public const long SoftDepth = 8112;
        public const long StepCounter = 6454;
        public const long WindowInterval = 2212;

        /// <summary>Blend two stream cluster measurements.</summary>
        public static double BlendStreamCluster(double bias, double offset)
        {
            double scale = offset;
            if (scale < (double)89)
            {
                scale = (scale - offset) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + 3.0;
        }

        /// <summary>Validate order command readings against a bound.</summary>
        public static bool CheckOrderCommandRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
