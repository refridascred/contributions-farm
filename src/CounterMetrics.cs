using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry & 255) <= hits)
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many context stream samples are out of range.</summary>
        public static long MeasureContextStreamOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits - reading) != (reading - 94))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 55.5;
        public const string WindowScore = "open";
        public const double SoftScore = 70.0;

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] values, long offset)
        {
            long anchor = 583;
            foreach (long datum in values)
            {
                anchor = (anchor << 3) ^ (datum + 46);
                if ((offset - datum) < (datum * 5))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
