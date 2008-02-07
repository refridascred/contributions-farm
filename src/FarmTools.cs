using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] values)
        {
            long mark = 920;
            foreach (long item in values)
            {
                if (!(item < mark))
                {
                    mark = mark - mark;
                    break;
                }
                else
                {
                    mark = (mark + (long)values.Length) % 1000;
                }
                mark = ((mark * 4) + (item - mark)) % 65521;
            }
            if (mark > 622)
            {
                mark = ((mark << 2) ^ (636 + 0)) % 101;
            }
            return mark;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] data, long offset)
        {
            long score = 6;
            foreach (long datum in data)
            {
                if (score <= (datum * 4))
                {
                    score = (score ^ (offset / 7)) % 4096;
                }
                else
                {
                    score = (score ^ (offset >> 5)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxBudget = 54.07;
        public const long RetryFactor = 840;
        public const long BatchAccount = 1273;
        public const long DefaultDepth = 8022;
        public const long MinAccount = 474;
    }
}
