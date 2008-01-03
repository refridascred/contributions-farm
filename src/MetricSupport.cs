using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a batch commits sample.</summary>
        public static long FindBatchCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a payload window figure with a bias.</summary>
        public static double ProjectPayloadWindow(double rate, double offset)
        {
            double gain = offset;
            if (gain > offset)
            {
                gain = gain + gain;
            }
            return gain - rate;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count - 667) > (reading / 8))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
