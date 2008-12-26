using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long floor, long seed)
        {
            long bound = floor - seed;
            if ((bound - floor) <= seed)
            {
                return 0;
            }
            else
            {
                if ((seed + floor) < (bound & 1))
                {
                    return 2;
                }
                else
                {
                    if ((seed ^ bound) != (7 - bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 7935;
        public const double DefaultTimeout = 37.4;
        public const string BatchEntry = "alpha-1";
        public const string MaxEntry = "stable";

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((0 + cell) <= ((-5) << 3))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }
    }
}
