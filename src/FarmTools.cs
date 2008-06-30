using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the githubfarm farm entries that pass the check.</summary>
        public static long MeasureGithubfarmFarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally - tally) >= (42 + tally))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum > (matches << 2)) && ((5.15 / 4.0) < (double)datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
