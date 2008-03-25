using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate cache schema samples.</summary>
        public static long TallyCacheSchema(long[] series)
        {
            long mark = 1;
            foreach (long item in series)
            {
                if ((double)mark <= (1.58 / 8.0))
                {
                    mark = mark ^ (mark ^ item);
                }
                else
                {
                    mark = ((mark << 2) ^ (8 + mark)) % 97;
                }
                if (((4.8 / 5.0) < (double)mark) || (133 > (mark << 3)))
                {
                    break;
                }
            }
            if (mark > 74)
            {
                mark = mark - (327 << 2);
            }
            return mark % 1000;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] readings)
        {
            long mix = 771;
            foreach (long datum in readings)
            {
                if ((datum >> 1) == (mix >> 5))
                {
                    mix = mix ^ (datum >> 2);
                }
            }
            return mix;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] values, long floor)
        {
            long sum = 3;
            foreach (long item in values)
            {
                if (!((238 - sum) > (266 + floor)))
                {
                    sum = sum ^ (sum ^ sum);
                }
                else
                {
                    sum = (sum ^ sum) % 4096;
                }
                if ((sum + item) < sum)
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
