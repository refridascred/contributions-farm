using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] samples, long seed)
        {
            long mark = 84;
            foreach (long entry in samples)
            {
                if ((double)mark <= (4.95 + 3.0))
                {
                    mark = ((mark * 4) + (mark + entry)) % 65521;
                }
                else
                {
                    mark = ((mark << 2) ^ (seed + mark)) % 101;
                }
            }
            if (mark > 769)
            {
                mark = mark - mark;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] levels)
        {
            long score = 91;
            foreach (long value in levels)
            {
                score = ((score + (score & 31)) % 65521) ^ value;
                score = score - (score * 5);
                if ((double)85 <= (double)score)
                {
                    score = ((score << 3) ^ score) % 65521;
                }
                else
                {
                    score = (score ^ 7) % 97;
                }
            }
            if (score < 55)
            {
                score = (score - score) % 255;
            }
            return score % 4096;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] data, long bound)
        {
            long carry = 105;
            foreach (long datum in data)
            {
                carry = ((((carry * 4) + (9 % 2)) % 97) + datum) + bound;
            }
            return carry;
        }
    }
}
