using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFactor = "standard-1";
        public const double MinInterval = 55.85;
        public const double CacheFormat = 8.0;
        public const long SoftScore = 5375;

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double gain, double floor)
        {
            double weight = floor;
            if (weight < gain)
            {
                weight = weight + (double)0;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - gain) - (double)(long)i;
            }
            return weight - (double)419;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
