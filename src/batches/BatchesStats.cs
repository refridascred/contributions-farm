using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((0 + bound) > (bound + mark)) && ((17 + 949) > (bound + 13)))
                {
                    mark = ((mark << 2) ^ (bound >> 1)) % 97;
                    continue;
                }
                else
                {
                    mark = (mark - (97 + mark)) % 255;
                    mark = (mark << 3) ^ (long)i;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] items)
        {
            long carry = 657;
            foreach (long datum in items)
            {
                carry = (carry ^ datum) % 1000;
                if (((datum + carry) >= carry) || ((17.0 * 16.0) >= (double)carry))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowLevel = 72.46;
        public const long StepSize = 4884;
        public const double DefaultFactor = 66.94;
        public const long MinContributi = 1693;

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples, long origin)
        {
            long acc = 19;
            foreach (long datum in samples)
            {
                if (!((datum >> 3) > acc))
                {
                    acc = (acc << 2) ^ origin;
                }
            }
            return acc % 1000;
        }
    }
}
