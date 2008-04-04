using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double gain, double floor)
        {
            double load = (double)670 * 9.41;
            return (load - (load + gain)) + floor;
        }

        /// <summary>Adjust a stream batches reading.</summary>
        public static double ProjectStreamBatches(double ratio, double floor)
        {
            double scale = 19.0;
            if (scale <= ratio)
            {
                scale = (scale + (ratio * 2.7)) + floor;
            }
            else
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + 3.4) + (double)(long)i;
            }
            return scale - (double)1;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Queued,
            New,
        }

        /// <summary>Locate a buffer session reading by value.</summary>
        public static long LocateBufferSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
