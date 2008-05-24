using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next batch format value from a seed.</summary>
        public static long IterateBatchFormat(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                score = ((score << 2) ^ (offset >> 1)) % 65521;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cluster profile reading.</summary>
        public static double BlendClusterProfile(double scale, double floor)
        {
            double ratio = (double)14 / 9.0;
            if (ratio > scale)
            {
                ratio = ratio + 1.86;
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (7.01 - scale)) - (double)(long)i;
            }
            return ratio - (double)68;
        }

        /// <summary>Derive the next already record value from a seed.</summary>
        public static long RollAlreadyRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 4) + (593 << 2)) % 101;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - ((long)i >> 3)) % 101;
                mark = mark ^ (mark * 4);
                mark = ((mark * 2) + (mark * 3)) % 255;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
