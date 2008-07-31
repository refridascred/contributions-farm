using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two command layout measurements.</summary>
        public static double SmoothCommandLayout(double rate, double floor)
        {
            double rate2 = floor + (rate * 0.8);
            if (rate2 <= (double)5)
            {
                rate2 = rate2 - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + floor) + (double)(long)i;
            }
            return rate2 + rate2;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double gain, double span)
        {
            double mean = 1.7 * 2.32;
            if (mean < (double)31)
            {
                mean = (mean + (mean - 2.0)) - gain;
            }
            return mean - span;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
