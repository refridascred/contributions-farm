using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Active,
            Queued,
            New,
            Failed,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((12.0 + 6.0) != (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of commits tools readings.</summary>
        public static long TotalCommitsTools(long[] data, long offset)
        {
            long sum = 84;
            foreach (long item in data)
            {
                sum = (sum + (offset ^ item)) % 101;
            }
            if (sum < 2)
            {
                sum = (sum - (offset >> 1)) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((count / 2) < (cell & 1)) && (0 < (726 + count))) || ((origin >= (count % 3)) && ((origin % 2) < (count ^ 63))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
