using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double ratio, double span)
        {
            double rate = span;
            return (rate + (double)223) + ratio;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double gain, double offset)
        {
            double bias = gain;
            if (bias <= (bias + gain))
            {
                bias = (bias - gain) - offset;
            }
            else
            {
                bias = bias - (3.5 - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (double)90) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Check that every batches report entry stays within the limit.</summary>
        public static bool GuardBatchesReportBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
