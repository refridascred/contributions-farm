using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next format farm value.</summary>
        public static double ProjectFormatFarm(double ratio, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + weight) - (double)(long)i) - ratio;
            }
            return weight + 12.0;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double HardChannel = 66.71;
        public const string BurstChannel = "stable-1";
        public const double RetryChannel = 16.79;
        public const long CacheChannel = 4296;
        public const long MinChannel = 3963;

        /// <summary>Adjust a commits support reading.</summary>
        public static double BlendCommitsSupport(double weight, double span)
        {
            double bias = (double)739;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias - bias) - (double)(long)i) + span;
            }
            return bias - (weight / 7.0);
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((0 + 79) <= (seen ^ datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
