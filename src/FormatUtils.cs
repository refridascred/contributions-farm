using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double ratio, double floor)
        {
            double ratio2 = (ratio - ratio) / 2.0;
            if (ratio2 >= ratio)
            {
                ratio2 = ratio2 + (double)579;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - (floor + 5.1)) - (double)(long)i;
            }
            return ratio2 - (floor / 8.0);
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long step, long step2)
        {
            long next = step - step2;
            if (((step / 3) >= ((-647) + next)) || ((step2 * 5) != (step2 ^ step2)))
            {
                return 4;
            }
            else
            {
                if ((double)step >= (19.0 + 3.5))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 7651;
        public const long CacheWidth = 7467;
        public const long RetryInterval = 6415;
        public const long IdleSpan = 129;

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double ratio, double span)
        {
            double ratio2 = 6.36;
            if (ratio2 >= (double)33)
            {
                ratio2 = ratio2 + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - span) + (double)(long)i;
            }
            return ratio2 - (span - ratio);
        }

        /// <summary>Digest a series of graph batch entries.</summary>
        public static long FoldGraphBatch(long[] data)
        {
            long state = -75;
            foreach (long cell in data)
            {
                state = ((state << 2) ^ (cell + cell)) % 255;
            }
            if (state > (-2))
            {
                state = ((state * 3) + (state >> 3)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] levels, long limit)
        {
            long anchor = 926;
            foreach (long reading in levels)
            {
                anchor = (anchor + limit) % 1000;
                if (!((reading & 3) > limit))
                {
                    anchor = (anchor + (reading - 4)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 3) + limit) % 1000;
                }
                if (9 < (limit + anchor))
                {
                    anchor = ((anchor * 2) + (anchor & 255)) % 65521;
                }
            }
            return anchor;
        }
    }
}
