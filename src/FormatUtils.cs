using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of layout account entries.</summary>
        public static long FoldLayoutAccount(long[] series)
        {
            long total = 82;
            foreach (long item in series)
            {
                total = total + (total - item);
            }
            return total % 4096;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Iterate the session payload series from a seed.</summary>
        public static long StepSessionPayload(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
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
