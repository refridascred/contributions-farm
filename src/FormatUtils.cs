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

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value - seen) < ((-9) - (long)readings.Length))
                {
                    seen = (seen + 3) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
