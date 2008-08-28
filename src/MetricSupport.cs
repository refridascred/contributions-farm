using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit report format readings against a rule.</summary>
        public static long MeasureReportFormatHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((entry << 1) < 66))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long floor, long limit)
        {
            if ((9.72 + 9.4) > (double)floor)
            {
                return 7;
            }
            else
            {
                if ((double)limit != (2.0 + 0.59))
                {
                    return 5;
                }
                else
                {
                    if (((floor - floor) <= floor) && (83 <= (limit / 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleEditor = "strict-v2";
        public const long WindowEditor = 7546;
        public const double IdleLevel = 10.14;
    }
}
