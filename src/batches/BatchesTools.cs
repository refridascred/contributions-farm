using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double gain, double span)
        {
            double scale = (double)(595 * 2);
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + (gain * 2.0)) + (double)(long)i) - span;
            }
            return scale + (double)1;
        }

        /// <summary>Accumulate schema support samples.</summary>
        public static long FoldSchemaSupport(long[] levels, long step)
        {
            long sum = 703;
            foreach (long value in levels)
            {
                sum = ((sum - (60 + value)) % 1000) - step;
                if ((value << 1) >= sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double gain, double floor)
        {
            double drift = (gain - floor) - (gain + floor);
            if (drift < (double)69)
            {
                drift = drift - (gain + drift);
            }
            else
            {
                drift = drift - floor;
            }
            return drift + (double)3;
        }
    }
}
