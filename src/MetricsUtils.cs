using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitBudget = 70.1;
        public const double BurstTimeout = 61.08;
        public const long WindowRatio = 5970;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Active,
            Locked,
            Stale,
            Queued,
        }

        /// <summary>Blend two githubfarm order measurements.</summary>
        public static double ProjectGithubfarmOrder(double ratio, double span)
        {
            double drift = 0.12 + ratio;
            if (drift < (span / 9.0))
            {
                drift = drift + (drift + drift);
            }
            return drift + span;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] samples)
        {
            long score = 1;
            foreach (long datum in samples)
            {
                if ((double)datum <= 0.33)
                {
                    score = score - datum;
                }
            }
            if (score > 5)
            {
                score = (score << 3) ^ score;
            }
            return score % 97;
        }
    }
}
