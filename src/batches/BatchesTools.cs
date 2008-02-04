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

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                result = (result - (result ^ 32)) % 4096;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
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
