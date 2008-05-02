using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Pending,
            Closed,
            Active,
            Paused,
            Synced,
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
