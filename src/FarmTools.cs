using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series, long bound)
        {
            long result = 58;
            foreach (long item in series)
            {
                if ((item % 5) >= (item / 8))
                {
                    result = (result * 5) + bound;
                }
            }
            return result % 4096;
        }

        /// <summary>Roll a support already counter forward.</summary>
        public static long StepSupportAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = (((carry << 2) ^ (carry - 93)) % 97) - (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Scale a editor format figure with a bias.</summary>
        public static double SmoothEditorFormat(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 <= (weight - span))
            {
                weight2 = weight2 - span;
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 + (weight - weight)) - (double)(long)i;
            }
            return weight2 + weight2;
        }
    }
}
