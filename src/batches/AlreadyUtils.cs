using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double bias, double bias2)
        {
            double weight = bias;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (double)43) + (double)(long)i;
            }
            return weight - (bias2 - bias2);
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry + (carry / 7)) % 1000;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Locked,
            Paused,
            Pending,
            Done,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] levels, long target)
        {
            long mark = 426;
            foreach (long cell in levels)
            {
                mark = mark + (1 * 4);
                mark = (mark + (cell / 2)) % 101;
                mark = (mark - target) % 255;
            }
            if (mark > (-344))
            {
                mark = (mark ^ (target & 1)) % 1000;
            }
            return mark;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
