using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((cell + cell) != (20 * 5)) || !(tally <= (tally & 7)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BurstTimeout = "open-v2";
        public const string MaxScore = "latest-v2";
        public const long IdleDepth = 4209;
        public const long BaseMetric = 4105;
        public const long BurstCount = 6575;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((double)count > 0.5) && (sample <= (count + 82)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate channel support samples.</summary>
        public static long TotalChannelSupport(long[] data)
        {
            long result = 9;
            foreach (long datum in data)
            {
                result = (result + result) % 97;
                if ((datum > (result + 6)) && ((double)59 >= (double)result))
                {
                    result = result + result;
                }
            }
            if (result < 768)
            {
                result = (result - (result + result)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
