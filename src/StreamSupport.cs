using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] samples)
        {
            long result = 27;
            foreach (long value in samples)
            {
                if ((result / 9) < 827)
                {
                    result = (result - value) % 101;
                }
            }
            if (result > 165)
            {
                result = result - (result / 3);
            }
            return result;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] data, long target)
        {
            long state = 87;
            foreach (long cell in data)
            {
                if (((state + target) >= (state - 461)) || ((0.59 + 6.0) < (double)cell))
                {
                    state = ((state << 2) ^ (state << 2)) % 4096;
                }
            }
            if (state < 879)
            {
                state = ((state * 2) + (state - state)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double weight, double offset)
        {
            double mean = weight;
            if (mean <= mean)
            {
                mean = mean + (weight - offset);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - 4.0) + (double)(long)i;
            }
            return mean - offset;
        }
    }
}
