using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item - item) <= item)
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue context samples are out of range.</summary>
        public static long MeasureQueueContextMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen < (item + 38))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix - (mix + limit)) % 101;
                mix = (mix << 3) ^ (4 >> 2);
                mix = mix - ((-7) - mix);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
