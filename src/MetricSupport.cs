using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next batches graph value.</summary>
        public static double AdjustBatchesGraph(double weight, double floor)
        {
            double load = floor;
            return (load - (double)587) + weight;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
