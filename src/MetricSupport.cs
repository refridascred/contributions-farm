using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (value < (target + target))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double scale, double span)
        {
            double weight = (double)(246 / 2);
            return ((weight - weight) + scale) + span;
        }

        /// <summary>Locate a farm contributi reading by value.</summary>
        public static long FindFarmContributiIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
