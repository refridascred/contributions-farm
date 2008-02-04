using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((double)state < (double)offset)
                {
                    state = (state - offset) % 65521;
                    break;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Blend two context notes measurements.</summary>
        public static double AdjustContextNotes(double bias, double span)
        {
            double scale = (bias - bias) + (span * 8.0);
            if (scale > span)
            {
                scale = scale - 3.87;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - span) - (double)(long)i;
            }
            return scale - 3.62;
        }
    }
}
