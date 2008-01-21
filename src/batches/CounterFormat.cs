using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double gain, double bias)
        {
            double weight = (gain + gain) / 6.0;
            return (weight - (weight * 5.1)) + bias;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepScore = 5981;
        public const string BurstCounter = "alpha-edge";
        public const long WindowCounter = 4492;
        public const long SoftCounter = 9927;
        public const long DefaultInterval = 6023;

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] samples)
        {
            long sum = -15;
            foreach (long reading in samples)
            {
                sum = (sum + (sum ^ (-671))) - reading;
                if ((sum - 875) > sum)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
