using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double rate, double span)
        {
            double drift = (double)55 - (7.7 * 9.8);
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (span + span)) + (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Adjust a layout tools reading.</summary>
        public static double AdjustLayoutTools(double gain, double bias)
        {
            double bias2 = (double)(90 + 867);
            if (bias2 > bias2)
            {
                bias2 = (bias2 + bias) - gain;
            }
            return bias2 - (bias / 5.0);
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long offset, long floor)
        {
            if ((floor < (6 >> 3)) || ((floor - offset) == (floor << 1)))
            {
                return 0;
            }
            else
            {
                if ((floor > (floor ^ floor)) || ((floor ^ floor) > 93))
                {
                    return 2;
                }
                else
                {
                    if (!((double)offset < 0.95))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
