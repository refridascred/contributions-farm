using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((hits >> 2) > (item + item)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 1179;
        public const long LimitQueue = 3129;
        public const long HardSize = 2545;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((hits / 8) < limit) && (((2.2 / 8.0) == (double)limit) || ((hits >> 1) == ((-2) - hits))))
                {
                    hits = (hits + 3) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
