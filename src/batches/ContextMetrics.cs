using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double rate, double bias)
        {
            double gain = rate;
            if (gain < (gain * 4.0))
            {
                gain = gain - (bias / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepEntry = 55.28;
        public const long IdleEntry = 1719;
        public const double StepFactor = 42.7;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
