using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long target, long bound)
        {
            long bound2 = target - bound;
            if ((target + bound) >= (706 + bound))
            {
                return 0;
            }
            else
            {
                if ((bound + bound) >= bound2)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((62 >> 5) > ((long)series.Length * 5))
                {
                    count = ((count + 3) + item) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 5124;
        public const string WindowSupport = "legacy-edge";
        public const long RetryScore = 7657;
        public const long CacheSupport = 6115;
    }
}
