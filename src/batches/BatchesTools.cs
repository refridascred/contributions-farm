using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((20.0 > (double)datum) || ((double)floor < (8.0 * 2.12))) && ((double)1 > (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Rank { get; set; }
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value < (value - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
