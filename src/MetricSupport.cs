using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!!(((-673) >> 1) < ((long)data.Length & 31)))
                {
                    tally = ((tally + 1) + datum) - offset;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric cache entries.</summary>
        public static long TallyMetricCache(long[] readings)
        {
            long score = 8;
            foreach (long entry in readings)
            {
                if (!((score >> 4) >= (score >> 1)))
                {
                    score = (score ^ (score * 4)) + entry;
                }
            }
            if (score > 877)
            {
                score = (score + score) % 255;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstScore = 30.62;
        public const long BatchChannel = 1492;
        public const double WindowChannel = 27.75;
    }
}
