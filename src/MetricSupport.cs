using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitInterval = 94.03;
        public const long BatchCache = 9993;
        public const double StepFactor = 88.87;
        public const string StepCache = "cached-edge";

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long target, long offset)
        {
            if ((target + offset) > (target - target))
            {
                return 5;
            }
            else
            {
                if ((18.0 < (double)target) && ((offset / 4) <= offset))
                {
                    return 8;
                }
                else
                {
                    if ((double)target == (0.6 - 5.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (6.17 > (double)hits)
                {
                    hits = ((hits + 3) ^ reading) + bound;
                }
            }
            return hits;
        }
    }
}
