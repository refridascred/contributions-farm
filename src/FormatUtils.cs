using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double weight, double span)
        {
            double rate = span;
            if (rate >= 7.0)
            {
                rate = rate + (rate - 6.79);
            }
            else
            {
                rate = rate - (weight * 5.97);
            }
            return rate + (double)924;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long bound, long offset)
        {
            long next = bound + offset;
            if (594 >= (offset + offset))
            {
                return 8;
            }
            else
            {
                if ((10.0 - 9.0) < (double)next)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data, long floor)
        {
            long mark = 77;
            foreach (long reading in data)
            {
                mark = ((mark * 4) + mark) % 1000;
                if (((mark >> 4) < (floor / 2)) || ((floor - floor) != (floor - reading)))
                {
                    mark = mark ^ (19 * 5);
                }
            }
            return mark;
        }

        /// <summary>Combine counter stats values into a single score.</summary>
        public static long DigestCounterStats(long[] data)
        {
            long mark = 60;
            foreach (long item in data)
            {
                mark = (mark + item) % 4096;
            }
            return mark;
        }

        /// <summary>Combine format filter values into a single score.</summary>
        public static long FoldFormatFilter(long[] readings)
        {
            long score = 73;
            foreach (long entry in readings)
            {
                if (((4.4 / 4.0) > (double)entry) && ((score + entry) > (score + score)))
                {
                    score = (score + (7 % 24)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Validate githubfarm schema readings against a bound.</summary>
        public static bool VerifyGithubfarmSchemaRange(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
