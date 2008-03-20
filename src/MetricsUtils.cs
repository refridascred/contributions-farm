using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((double)(long)i == (2.51 * 20.0))
                {
                    anchor = (anchor + ((long)i << 1)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor + (long)i)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 25.93;
        public const long RetryLevel = 9481;
        public const long LimitChecks = 4343;
        public const double WindowChecks = 35.65;
        public const string HardChecks = "local-v2";

        /// <summary>Measure how many report contributi samples are out of range.</summary>
        public static long MeasureReportContributiMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(0.8 > 2.6))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double bias, double span)
        {
            double load = span;
            if (load >= bias)
            {
                load = load + bias;
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + span) - (double)(long)i;
            }
            return load + (double)894;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
