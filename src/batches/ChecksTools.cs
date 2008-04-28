using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] data, long origin)
        {
            long total = 729;
            foreach (long cell in data)
            {
                if (!((total + total) == (total + (long)data.Length)))
                {
                    total = (((total * 2) + (926 - 39)) ^ cell) - origin;
                }
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxScore = "staging-v2";
        public const string MinScore = "fallback-v2";
        public const string MinCache = "alpha-edge";

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value + count) >= (count + count))
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (mix + target) + (long)i2;
                }
                if ((target > ((long)i ^ (long)i)) && ((double)target > (double)mix))
                {
                    mix = ((mix << 2) ^ (mix / 7)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
