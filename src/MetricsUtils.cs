using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit account commits readings against a rule.</summary>
        public static long TallyAccountCommitsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((((double)tally > (1.7 - 9.8)) && ((8 >> 4) <= value)) || ((value / 4) >= ((-428) + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count queue contributi pairs that satisfy a relation.</summary>
        public static long MatchQueueContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
