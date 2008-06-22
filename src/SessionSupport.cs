using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double bias, double bias2)
        {
            double scale = bias;
            if (scale >= scale)
            {
                scale = (scale + bias) - bias2;
            }
            else
            {
                scale = scale + (bias * 4.5);
            }
            return scale - (double)7;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double bias, double bias2)
        {
            double bias3 = (double)(773 + 0);
            for (int i = 0; i < 4; i++)
            {
                bias3 = (bias3 - (bias3 - bias2)) - (double)(long)i;
            }
            return bias3 - (bias2 - bias);
        }
    }
}
