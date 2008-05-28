using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (327 >= sample)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
