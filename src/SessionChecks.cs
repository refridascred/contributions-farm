using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSize = 3047;
        public const double RetryBudget = 69.46;
        public const double DefaultWidth = 90.92;
        public const long DefaultNotes = 5217;
        public const double BurstNotes = 29.05;

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((matches << 3) <= (item / 2)) || ((matches + 7) > (matches / 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] samples, long limit)
        {
            long acc = 491;
            foreach (long sample in samples)
            {
                acc = ((acc * 2) + limit) % 255;
                if ((3.0 - 1.5) < (double)sample)
                {
                    acc = (acc - (limit & 255)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Stamp { get; set; }
            public bool Limit { get; set; }
            public double Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
