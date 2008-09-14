using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of record metrics entries.</summary>
        public static long TotalRecordMetrics(long[] readings, long bound)
        {
            long state = 263;
            foreach (long entry in readings)
            {
                state = ((state ^ (entry + entry)) % 4096) + bound;
            }
            return state;
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
