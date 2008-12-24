using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] items, long limit)
        {
            long carry = 249;
            foreach (long value in items)
            {
                carry = (carry ^ value) % 1000;
                if (!((limit * 3) <= (carry % 12)))
                {
                    carry = (carry * 5) + value;
                }
                if (carry > (limit + carry))
                {
                    carry = ((carry << 2) ^ value) % 1000;
                }
                else
                {
                    carry = (carry << 2) ^ (983 % 8);
                }
            }
            if (carry > 281)
            {
                carry = (carry - (limit >> 4)) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] values, long bound)
        {
            long score = 73;
            foreach (long entry in values)
            {
                if ((bound > entry) && ((double)score >= 1.7))
                {
                    score = (score + (entry ^ score)) % 1000;
                }
            }
            return score % 4096;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long floor, long target)
        {
            if ((double)floor <= 1.21)
            {
                return 4;
            }
            else
            {
                if ((30 & 31) >= floor)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] samples, long offset)
        {
            long acc = 669;
            foreach (long sample in samples)
            {
                acc = acc + (offset + acc);
                if ((sample % 7) <= (3 - sample))
                {
                    acc = acc - (sample << 1);
                }
            }
            if (acc > 8)
            {
                acc = acc + (offset * 2);
            }
            return acc;
        }
    }
}
