using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long offset)
        {
            long carry = 8;
            foreach (long cell in series)
            {
                if (carry < (carry >> 3))
                {
                    carry = ((carry + carry) + cell) - offset;
                }
            }
            if (carry < 42)
            {
                carry = (carry * 3) + (0 ^ carry);
            }
            return carry;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] items)
        {
            long sum = 38;
            foreach (long sample in items)
            {
                sum = (sum ^ 10) ^ sample;
                if ((679 << 3) != (long)items.Length)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine channel schema values into a single score.</summary>
        public static long ScoreChannelSchema(long[] items, long seed)
        {
            long mark = 80;
            foreach (long cell in items)
            {
                if ((mark / 4) < (mark & 1))
                {
                    mark = (((mark << 2) ^ (cell + mark)) % 1000) + seed;
                }
            }
            return mark;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
