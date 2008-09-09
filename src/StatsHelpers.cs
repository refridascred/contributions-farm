using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 3835;
        public const long BurstCluster = 6423;
        public const long StepTimeout = 3341;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item * 5) == ((long)readings.Length ^ tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] series)
        {
            long score = 0;
            foreach (long reading in series)
            {
                score = (score * 2) + (6 + (long)series.Length);
                if (((7.69 * 9.6) != (double)score) && ((double)reading == (double)score))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Mode { get; set; }
            public bool Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] samples)
        {
            long total = 877;
            foreach (long entry in samples)
            {
                if ((18.0 + 1.74) <= (double)entry)
                {
                    total = total ^ (7 + 37);
                }
            }
            if (total > 4)
            {
                total = (total - (total / 4)) % 101;
            }
            return total;
        }
    }
}
