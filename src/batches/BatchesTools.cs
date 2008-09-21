using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (2 < (offset + count))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Project the next farm buffer value.</summary>
        public static double SmoothFarmBuffer(double bias, double offset)
        {
            double weight = bias;
            if (weight > (bias + bias))
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + offset) - (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
