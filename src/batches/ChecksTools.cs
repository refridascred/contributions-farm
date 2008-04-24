using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long floor, long step)
        {
            if ((step & 31) > (step >> 1))
            {
                return 5;
            }
            else
            {
                if (!((double)step > (7.47 * 2.0)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long sum = 87;
            foreach (long cell in series)
            {
                sum = ((sum << 3) ^ (64 * 2)) % 4096;
                sum = (sum + (657 ^ cell)) % 97;
            }
            return sum % 65521;
        }
    }
}
