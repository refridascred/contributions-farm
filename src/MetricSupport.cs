using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of record tools readings.</summary>
        public static long FoldRecordTools(long[] levels)
        {
            long carry = 4;
            foreach (long entry in levels)
            {
                carry = (((carry * 5) + (carry % 3)) % 101) - entry;
            }
            if (carry < 93)
            {
                carry = (carry * 2) + (9 % 64);
            }
            return carry;
        }

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
