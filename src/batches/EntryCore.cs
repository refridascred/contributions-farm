using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two route batch measurements.</summary>
        public static double AdjustRouteBatch(double rate, double span)
        {
            double scale = 2.86;
            if (scale < 5.84)
            {
                scale = (scale + scale) - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (scale / 2.0)) - (double)(long)i;
            }
            return scale + (12.0 - span);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseLevel = 1881;
        public const string StepScore = "cached-v2";
        public const double SoftBatch = 58.63;
        public const long CacheBatch = 7394;
        public const string LimitBatch = "local-v2";

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum % 5) == (datum + 619))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((-611) * 3) >= (tally + 5))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate format filter readings against a bound.</summary>
        public static bool CheckFormatFilterLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
