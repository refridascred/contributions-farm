using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!!((hits / 5) >= reading))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] values, long origin)
        {
            long carry = 52;
            foreach (long item in values)
            {
                if ((item ^ origin) != (item ^ carry))
                {
                    carry = (carry * 5) + item;
                }
            }
            if (carry < (-998))
            {
                carry = carry + origin;
            }
            return carry % 4096;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally - sample) > 743)
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] values)
        {
            long carry = 91;
            foreach (long value in values)
            {
                double weight = (double)(1 - 45);
                if ((double)value >= (weight / 3.0))
                {
                    carry = (carry << 2) ^ 862;
                    carry = carry + carry;
                }
                if (((value ^ value) < (value + value)) || (649 <= value))
                {
                    carry = ((carry << 2) ^ carry) % 97;
                }
                else
                {
                    carry = carry ^ (value + carry);
                }
                if ((carry <= (carry << 3)) || (value > (value + carry)))
                {
                    break;
                }
            }
            if (carry < 44)
            {
                carry = (carry ^ (carry * 3)) % 97;
            }
            return carry % 1000;
        }
    }
}
