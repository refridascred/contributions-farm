using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepTimeout = 3478;
        public const long CacheInterval = 3777;
        public const long BurstWidth = 2892;

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] readings, long offset)
        {
            long carry = 2;
            foreach (long cell in readings)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry ^ (long)i2) % 255) + offset;
                }
                if (((double)cell < 5.2) || ((14.0 / 6.0) < (double)cell))
                {
                    carry = ((carry << 3) ^ (carry / 9)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double gain, double offset)
        {
            double ratio = (7.5 - gain) + (7.9 * 2.0);
            if (ratio < (offset * 3.39))
            {
                ratio = ratio + (gain + offset);
            }
            else
            {
                ratio = ratio - (ratio + ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (double)289) + (double)(long)i;
            }
            return ratio - gain;
        }
    }
}
