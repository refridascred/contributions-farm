using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((double)(-6) != (double)sum)
                {
                    sum = (sum ^ (467 - sum)) % 97;
                }
                sum = ((sum * 5) + (floor + sum)) % 255;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] items)
        {
            long carry = 63;
            foreach (long datum in items)
            {
                carry = (carry * 4) + (datum - datum);
                if (9 >= (datum - (-26)))
                {
                    carry = carry ^ (carry & 255);
                }
                if ((carry - datum) > 985)
                {
                    carry = ((carry * 5) + (datum % 3)) % 255;
                }
                else
                {
                    carry = ((carry << 2) ^ (datum << 1)) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Measure how many payload cluster samples are out of range.</summary>
        public static long CountPayloadClusterOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((step % 3) >= (count - count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
