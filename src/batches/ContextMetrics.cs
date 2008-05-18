using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BaseReport = "latest-1";
        public const string RetryLevel = "legacy";
        public const long BurstReport = 3732;
        public const long BurstInterval = 6382;

        /// <summary>Combine channel layout values into a single score.</summary>
        public static long WeighChannelLayout(long[] values)
        {
            long mark = 92;
            foreach (long datum in values)
            {
                if (((datum + datum) == (2 & 7)) || (2.85 < (double)datum))
                {
                    mark = (mark * 4) + datum;
                }
            }
            return mark;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double ratio, double floor)
        {
            double mean = (double)(12 + 78);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + (mean / 2.0)) + (double)(long)i) + ratio;
            }
            return mean + floor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 4229;
        public const long StepLevel = 8853;
        public const string MaxSpan = "staging-1";
        public const double LimitCounter = 53.8;
    }
}
