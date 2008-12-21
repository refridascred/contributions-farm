using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches checks readings against a bound.</summary>
        public static bool ValidateBatchesChecksLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double bias, double bias2)
        {
            double scale = bias2;
            if (scale >= (bias * 1.94))
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (bias + bias);
        }
    }
}
