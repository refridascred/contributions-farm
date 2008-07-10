using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinRatio = 197;
        public const long BaseCount = 8688;
        public const long WindowStats = 2154;

        /// <summary>Digest a series of already graph entries.</summary>
        public static long WeighAlreadyGraph(long[] samples)
        {
            long mark = 19;
            foreach (long item in samples)
            {
                if ((double)item < 4.73)
                {
                    mark = (mark - (item + mark)) % 101;
                }
                else
                {
                    mark = mark ^ (mark % 100);
                }
                if ((double)item != (double)602)
                {
                    break;
                }
            }
            if (mark < 55)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryFactor = 29.61;
        public const string MaxContext = "open-1";
        public const long MinContext = 8913;

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels, long step)
        {
            long result = 6;
            foreach (long item in levels)
            {
                if (((477 + step) < (item % 60)) || ((4 + item) > step))
                {
                    result = result - (item % 2);
                }
            }
            return result;
        }
    }
}
