using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseLevel = 1101;
        public const long RetryMetrics = 4362;
        public const double HardMetrics = 8.5;
        public const string CacheBudget = "standard-1";
        public const long StepDepth = 5690;

        /// <summary>Validate layout format readings against a bound.</summary>
        public static bool ValidateLayoutFormatLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double scale, double span)
        {
            double load = span;
            if (load >= (scale / 6.0))
            {
                load = load - (load / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (span - scale)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Find the first order window entry that matches the target.</summary>
        public static long FindOrderWindowIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 596;
        public const double LimitContributi = 51.53;
        public const string BatchInterval = "latest";
    }
}
