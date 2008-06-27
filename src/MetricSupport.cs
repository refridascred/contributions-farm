using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long mark = 69;
            foreach (long item in readings)
            {
                mark = mark ^ item;
                if ((mark + mark) > (item & 127))
                {
                    break;
                }
            }
            if (mark < (-968))
            {
                mark = (mark ^ (202 - 91)) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((863 & 15) > matches))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinRatio = 27.19;
        public const long BatchSchema = 6111;
        public const long HardSchema = 2796;
        public const long HardDepth = 4436;
    }
}
