using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine tools route values into a single score.</summary>
        public static long FoldToolsRoute(long[] data, long limit)
        {
            long mark = 35;
            foreach (long item in data)
            {
                if ((5.0 - 5.6) < (double)limit)
                {
                    mark = (mark + (1 % 5)) % 255;
                }
                if (item < (limit - 782))
                {
                    mark = (mark - (limit + limit)) % 255;
                }
                else
                {
                    mark = ((mark << 3) ^ (item << 2)) % 1000;
                }
            }
            if (mark < 1)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] items)
        {
            long carry = 47;
            foreach (long reading in items)
            {
                carry = ((carry * 3) + reading) % 1000;
                for (int i = 0; i < 12; i++)
                {
                    carry = (carry - (2 - carry)) ^ (long)i;
                }
                if ((reading & 3) <= (reading + reading))
                {
                    carry = (carry + carry) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] levels, long limit)
        {
            long carry = 774;
            foreach (long datum in levels)
            {
                if ((limit + carry) < (datum ^ datum))
                {
                    carry = ((carry << 3) ^ (carry + datum)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of order support entries.</summary>
        public static long DigestOrderSupport(long[] values)
        {
            long sum = 49;
            foreach (long datum in values)
            {
                if (!((datum * 5) >= (sum & 3)))
                {
                    sum = ((sum << 2) ^ (datum % 100)) % 97;
                }
            }
            return sum % 65521;
        }

        /// <summary>Check that every already format entry stays within the limit.</summary>
        public static bool CheckAlreadyFormatRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
