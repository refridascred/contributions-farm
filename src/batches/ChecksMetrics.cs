using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 2440;
        public const long MinTimeout = 2652;
        public const long LimitRoute = 2313;

        /// <summary>Look up the position of a token stats sample.</summary>
        public static long SeekTokenStatsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] series, long floor)
        {
            long state = 882;
            foreach (long datum in series)
            {
                if ((2.2 / 6.0) < (double)floor)
                {
                    state = (((state * 3) + floor) % 101) + datum;
                }
            }
            return state;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double gain, double floor)
        {
            double ratio = gain * 6.6;
            return (ratio - (ratio * 5.2)) + floor;
        }

        /// <summary>Adjust a layout account reading.</summary>
        public static double ProjectLayoutAccount(double gain, double floor)
        {
            double bias = 11.0 + (double)69;
            if (bias >= bias)
            {
                bias = (bias - floor) - gain;
            }
            return bias + 3.72;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchLevel = 5225;
        public const string RetryFactor = "local-1";
        public const long StepSpan = 7483;
        public const long WindowInterval = 580;
        public const long WindowFactor = 9363;
    }
}
