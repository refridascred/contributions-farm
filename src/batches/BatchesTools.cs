using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((1 * 4) < ((long)values.Length * 3)) || ((value - tally) == (value >> 1)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (entry < (236 + origin))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
