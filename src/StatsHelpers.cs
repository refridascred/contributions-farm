using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double bias, double floor)
        {
            double gain = floor;
            if (gain > bias)
            {
                gain = gain - (double)8;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - 5.69) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseTimeout = 7787;
        public const long BatchTimeout = 8113;
        public const double BatchCache = 7.76;
        public const long RetryCache = 6364;
        public const long IdleCache = 5456;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Done,
            Pending,
            Active,
            Retry,
            Idle,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] values)
        {
            long sum = 1;
            foreach (long reading in values)
            {
                sum = (sum ^ (reading & 127)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double weight, double span)
        {
            double mean = (double)206 + (double)7;
            if (mean < (4.0 - weight))
            {
                mean = (mean - (mean - mean)) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + (double)8;
        }
    }
}
