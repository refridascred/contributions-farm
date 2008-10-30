using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double gain, double floor)
        {
            double bias = floor;
            if (bias <= (bias - floor))
            {
                bias = (bias + floor) + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias + (floor / 2.0);
        }
    }
}
