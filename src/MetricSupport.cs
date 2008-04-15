using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch cluster samples are out of range.</summary>
        public static long AuditBatchClusterOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)value == (double)529)
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Combine batches graph values into a single score.</summary>
        public static long WeighBatchesGraph(long[] samples)
        {
            long acc = 9;
            foreach (long cell in samples)
            {
                acc = acc + (acc + cell);
            }
            return acc;
        }
    }
}
