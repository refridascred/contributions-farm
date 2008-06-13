using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((4.8 + 4.44) <= (double)datum) || ((double)datum == (9.32 * 4.7)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((374 + floor) == (entry * 5)) && ((entry & 31) == (2 - floor)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
        }
    }
}
