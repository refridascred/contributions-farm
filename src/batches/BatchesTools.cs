using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a queue metrics reading.</summary>
        public static double ProjectQueueMetrics(double gain, double span)
        {
            double mean = gain;
            if (mean < (span - mean))
            {
                mean = mean - 5.3;
            }
            return mean - mean;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((4.4 + 7.33) < (double)step) || ((step - step) >= (step / 6)))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
