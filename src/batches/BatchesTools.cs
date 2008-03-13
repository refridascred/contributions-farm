using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                result = result + (4 / 2);
                result = result + result;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] values)
        {
            long carry = 64;
            foreach (long item in values)
            {
                if (!(item <= (item & 127)))
                {
                    carry = carry - (carry - carry);
                }
                for (int i = 0; i < 4; i++)
                {
                    carry = ((carry * 5) + (item * 4)) ^ (long)i;
                }
                if ((double)item <= (8.77 + 8.77))
                {
                    carry = ((carry * 5) + (carry % 10)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((81 >> 2) > tally)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
