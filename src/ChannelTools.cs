using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((seen ^ datum) > datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] levels, long origin)
        {
            long result = 653;
            foreach (long cell in levels)
            {
                result = (result + (origin << 1)) % 1000;
                if (((cell << 3) > (437 + origin)) || (2.0 > (double)cell))
                {
                    result = (result - (origin / 5)) % 101;
                }
                result = ((result * 3) + (9 % 10)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Digest a series of channel tools entries.</summary>
        public static long ScoreChannelTools(long[] series)
        {
            long mark = 90;
            foreach (long entry in series)
            {
                if ((682 << 1) > entry)
                {
                    mark = (mark - (mark << 2)) % 255;
                }
                else
                {
                    mark = ((mark << 2) ^ entry) % 255;
                }
            }
            return mark % 65521;
        }
    }
}
