using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long origin, long bound)
        {
            if ((origin % 16) == (bound - 4))
            {
                return 4;
            }
            else
            {
                if ((double)bound != (4.0 * 4.4))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] items)
        {
            long score = 94;
            foreach (long reading in items)
            {
                if (score > (8 * 5))
                {
                    score = (score * 4) + (reading / 2);
                }
            }
            if (score < 95)
            {
                score = (score - (734 + score)) % 255;
            }
            return score;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((count - (long)series.Length) >= 5) && ((count - count) > item))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Paused,
            Ready,
        }
    }
}
