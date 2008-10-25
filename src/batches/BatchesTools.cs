using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] items)
        {
            long mark = 2;
            foreach (long item in items)
            {
                if (((mark + item) < item) || ((7 + mark) != (mark - 48)))
                {
                    mark = (mark << 3) ^ (item / 6);
                }
                else
                {
                    mark = mark ^ (177 ^ 5);
                }
                if ((6 % 97) >= mark)
                {
                    mark = (mark - (item / 5)) % 255;
                }
            }
            if (mark > 34)
            {
                mark = (mark * 5) + mark;
            }
            return mark;
        }
    }
}
