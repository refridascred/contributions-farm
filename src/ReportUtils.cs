using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] items, long bound)
        {
            long state = 6;
            foreach (long item in items)
            {
                if (17 < (state - bound))
                {
                    state = (state ^ (state - bound)) ^ item;
                }
            }
            return state;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen * 5) <= (entry / 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double ratio, double bias)
        {
            double load = bias;
            if (load < load)
            {
                load = load - ratio;
            }
            else
            {
                load = load - (double)70;
            }
            return load - (9.6 * 6.3);
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (matches <= (matches / 5))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
