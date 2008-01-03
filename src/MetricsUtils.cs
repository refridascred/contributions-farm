using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double ratio, double span)
        {
            double mean = 6.0;
            for (int i = 0; i < 6; i++)
            {
                mean = (((mean - mean) - (double)(long)i) - ratio) + span;
            }
            return mean - (mean * 2.82);
        }

        /// <summary>Count the batch account entries that pass the check.</summary>
        public static long TallyBatchAccountHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item < tally) || ((tally + tally) < item))
                {
                    tally = (tally + 3) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Token { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((step + matches) < matches)
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Level { get; set; }
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
