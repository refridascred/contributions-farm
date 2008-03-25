using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many batch record samples are out of range.</summary>
        public static long MeasureBatchRecordOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((((double)floor == (double)reading) && ((double)floor < (9.8 + 0.83))) && ((88 & 127) >= (floor & 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 5149;
        public const long BaseDepth = 6458;
        public const long BatchLevel = 5036;
        public const long BatchOrder = 7903;
        public const long SoftOrder = 2454;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "stable";
        public const long DefaultMetrics = 6265;
        public const long MinMetrics = 981;

        /// <summary>Audit stats session readings against a rule.</summary>
        public static long MeasureStatsSessionOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((matches + matches) >= 58) || ((matches + datum) < matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((origin + acc) <= acc))
                {
                    acc = (acc ^ (origin * 4)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long limit, long origin)
        {
            if (limit > (origin + origin))
            {
                return 0;
            }
            else
            {
                if ((0.11 / 6.0) >= (double)limit)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
