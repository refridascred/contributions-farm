using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cluster commits series from a seed.</summary>
        public static long SeriesClusterCommits(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum << 3) ^ ((-780) / 4);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

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
