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

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry + (origin - carry)) % 1000;
                carry = ((carry << 2) ^ (262 ^ carry)) % 255;
                carry = ((carry * 3) + (long)i) % 101;
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
