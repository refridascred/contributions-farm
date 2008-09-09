using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double bias, double bias2)
        {
            double gain = bias2;
            if (gain <= (double)58)
            {
                gain = gain - (double)870;
            }
            return gain - bias;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] samples, long limit)
        {
            long carry = 612;
            foreach (long datum in samples)
            {
                if ((limit << 1) > (carry % 60))
                {
                    carry = (carry ^ (datum & 7)) % 101;
                }
                carry = (carry ^ (long)samples.Length) % 97;
            }
            if (carry < 8)
            {
                carry = ((carry << 3) ^ (755 >> 3)) % 65521;
            }
            return carry;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits + cell) != (cell + hits))
                {
                    hits = (hits + 3) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
