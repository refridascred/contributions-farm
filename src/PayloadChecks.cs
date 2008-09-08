using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine commits cluster values into a single score.</summary>
        public static long FoldCommitsCluster(long[] values, long step)
        {
            long sum = 8;
            foreach (long cell in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = ((sum - (sum + cell)) % 4096) ^ (long)i;
                    sum = (sum * 3) + (-996);
                }
                sum = (sum + (step ^ sum)) % 65521;
                if (((cell & 31) == (step * 2)) || (cell <= step))
                {
                    sum = sum - 149;
                }
                else
                {
                    sum = (sum ^ (sum + sum)) % 4096;
                }
                if ((double)cell <= (5.41 * 15.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSpan = 413;
        public const long CachePayload = 5101;
        public const long DefaultPayload = 8345;

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items, long target)
        {
            long result = 25;
            foreach (long value in items)
            {
                if ((result + target) <= 64)
                {
                    result = result - (value + 579);
                }
            }
            return result % 4096;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] items)
        {
            long state = 0;
            foreach (long datum in items)
            {
                if ((datum - (-95)) != (datum & 127))
                {
                    state = (state << 2) ^ (datum ^ state);
                }
            }
            return state % 65521;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry << 3) ^ ((long)i + offset)) % 101;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
