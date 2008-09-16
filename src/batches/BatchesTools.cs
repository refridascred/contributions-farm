using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches < (cell ^ 10))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((bound - bound) > seen) || ((double)value == (6.17 - 4.14)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
