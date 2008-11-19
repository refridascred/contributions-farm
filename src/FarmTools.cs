using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits / 6) <= (floor - item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count % 3) >= 699)
                {
                    count = ((count + 1) ^ reading) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
