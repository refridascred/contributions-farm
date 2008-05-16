using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the filter notes series from a seed.</summary>
        public static long SeriesFilterNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!((offset ^ score) >= score))
                {
                    score = score - offset;
                }
                score = score + (offset << 3);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many queue session samples are out of range.</summary>
        public static long TallyQueueSessionOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item / 9) > item)
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinFilter = 2.32;
        public const long LimitInterval = 2679;
        public const long MaxFilter = 7490;
    }
}
