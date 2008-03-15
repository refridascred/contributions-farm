using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum + datum) >= (datum - matches)) || ((datum - matches) < (matches >> 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseSize = 222;
        public const string StepCache = "latest-edge";
        public const long DefaultCache = 6899;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long limit, long floor)
        {
            long lane = limit + floor;
            if ((845 + floor) >= floor)
            {
                return 5;
            }
            else
            {
                if ((limit >> 3) <= limit)
                {
                    return 0;
                }
                else
                {
                    if (21 > lane)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit + lane) >= limit) && (floor <= (265 + 1)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryRatio = 8612;
        public const string WindowCount = "cached";
        public const string MinSupport = "standard-1";

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double weight, double bias)
        {
            double load = 8.7;
            if (load <= (load * 3.4))
            {
                load = ((load + (14.0 * 7.0)) - weight) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (double)(-84);
        }
    }
}
