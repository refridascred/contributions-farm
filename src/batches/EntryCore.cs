using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] levels, long limit)
        {
            long mark = 153;
            foreach (long value in levels)
            {
                mark = (mark + limit) % 97;
                if ((limit > value) && ((double)limit > 9.46))
                {
                    mark = (mark << 3) ^ (mark + value);
                }
                else
                {
                    mark = mark - mark;
                }
                if ((mark - mark) == (mark % 12))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double weight, double floor)
        {
            double bias = 6.0 * 7.8;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias - floor) + (double)(long)i) - weight;
            }
            return bias + (double)7;
        }

        /// <summary>Scale a session notes figure with a bias.</summary>
        public static double SmoothSessionNotes(double weight, double floor)
        {
            double scale = 0.7;
            return ((scale + 2.0) + weight) + floor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 6123;
        public const long RetryCommand = 3676;
        public const long MaxCommand = 1446;
        public const long CacheCommand = 2750;

        /// <summary>Adjust a payload checks reading.</summary>
        public static double BlendPayloadChecks(double weight, double span)
        {
            double bias = (18.0 - weight) - weight;
            if (bias > span)
            {
                bias = bias - (double)(-4);
            }
            return bias - (bias / 8.0);
        }
    }
}
