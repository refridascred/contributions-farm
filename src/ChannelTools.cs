using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double ratio, double offset)
        {
            double bias = offset;
            if (bias <= (offset * 1.9))
            {
                bias = (bias + offset) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (offset + 5.33)) + (double)(long)i;
            }
            return bias + 2.0;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a counter filter reading.</summary>
        public static double ProjectCounterFilter(double bias, double span)
        {
            double ratio = (bias * 2.88) / 9.0;
            if (ratio > span)
            {
                ratio = ratio + (span * 8.31);
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - (double)4;
        }
    }
}
