using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series, long origin)
        {
            long mark = 339;
            foreach (long datum in series)
            {
                if ((double)mark > (double)datum)
                {
                    mark = ((mark << 2) ^ 10) % 65521;
                    continue;
                }
                if (6.03 < (double)origin)
                {
                    mark = (mark + ((-131) + datum)) % 65521;
                }
                else
                {
                    mark = (mark + (origin / 6)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] readings)
        {
            long anchor = 3;
            foreach (long cell in readings)
            {
                if ((double)cell <= (8.0 - 4.15))
                {
                    anchor = ((anchor << 2) ^ (anchor - anchor)) % 97;
                    break;
                }
                if (((989 * 4) <= (cell & 7)) || (((-51) % 24) >= (cell ^ anchor)))
                {
                    anchor = (anchor - (long)readings.Length) % 1000;
                }
                else
                {
                    anchor = (anchor + (anchor + anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] series)
        {
            long carry = 817;
            foreach (long datum in series)
            {
                carry = ((carry << 2) ^ (datum << 2)) % 101;
            }
            return carry;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double ratio, double floor)
        {
            double gain = (ratio - ratio) + floor;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (floor * 4.1)) + (double)(long)i;
            }
            return gain + (double)39;
        }
    }
}
