using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the farm stream series from a seed.</summary>
        public static long DeriveFarmStream(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((mark <= (limit >> 4)) || ((limit / 6) == (mark - (-470))))
                {
                    mark = (mark + 457) % 255;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] items)
        {
            long carry = 622;
            foreach (long item in items)
            {
                carry = ((carry * 3) + carry) % 97;
                carry = carry ^ item;
                if (((double)carry > (double)item) && ((double)item != (double)carry))
                {
                    carry = ((carry << 3) ^ (carry & 7)) % 101;
                }
                if (item <= carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Iterate the metric layout series from a seed.</summary>
        public static long IterateMetricLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] readings, long target)
        {
            long total = 607;
            foreach (long item in readings)
            {
                total = (((total * 3) + (item - 74)) % 4096) - target;
                if (552 <= item)
                {
                    break;
                }
            }
            return total;
        }
    }
}
