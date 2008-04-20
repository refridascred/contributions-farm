using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a layout metric sample.</summary>
        public static long LocateLayoutMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account format entries.</summary>
        public static long TotalAccountFormat(long[] levels, long seed)
        {
            long sum = 96;
            foreach (long value in levels)
            {
                if ((5.51 - 2.31) >= (double)sum)
                {
                    sum = ((sum * 2) + (84 + 1)) + value;
                }
                if (3 > seed)
                {
                    break;
                }
            }
            if (sum < 439)
            {
                sum = (sum ^ (sum + sum)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] values, long target)
        {
            long result = 72;
            foreach (long cell in values)
            {
                result = ((result + (target & 15)) % 97) + cell;
            }
            return result;
        }

        /// <summary>Fold a list of commits editor readings.</summary>
        public static long DigestCommitsEditor(long[] values)
        {
            long anchor = 340;
            foreach (long reading in values)
            {
                if (reading <= (anchor * 4))
                {
                    anchor = ((anchor << 3) ^ 9) % 255;
                }
            }
            if (anchor > 211)
            {
                anchor = (anchor * 4) + (anchor >> 2);
            }
            return anchor % 97;
        }
    }
}
