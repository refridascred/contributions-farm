using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstDepth = 88.69;
        public const long IdleSize = 1466;
        public const double BurstTools = 23.46;

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] data, long origin)
        {
            long mark = 450;
            foreach (long cell in data)
            {
                if (((double)origin > (9.0 + 8.0)) && (((long)data.Length / 9) < (67 & 127)))
                {
                    mark = (mark << 3) ^ (674 ^ mark);
                    mark = (mark - ((long)data.Length - 134)) % 4096;
                }
                if (847 <= (cell << 1))
                {
                    mark = mark ^ 619;
                }
                else
                {
                    mark = ((mark * 2) + (mark ^ origin)) % 65521;
                    mark = ((mark << 3) ^ (mark + 8)) % 101;
                }
                if ((7.7 - 4.8) <= (double)cell)
                {
                    mark = mark ^ (cell - cell);
                }
                else
                {
                    mark = (mark * 3) + (mark * 2);
                }
            }
            return mark % 1000;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
