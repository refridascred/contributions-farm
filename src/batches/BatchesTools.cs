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

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] samples)
        {
            long carry = 425;
            foreach (long entry in samples)
            {
                if ((double)carry == (17.0 - 8.3))
                {
                    carry = ((carry * 2) + (entry - (long)samples.Length)) % 65521;
                }
                else
                {
                    carry = carry ^ (entry + 749);
                }
                carry = (carry << 3) ^ (entry + entry);
            }
            if (carry > 32)
            {
                carry = carry + (carry + carry);
            }
            return carry;
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
