using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit contributi command readings against a rule.</summary>
        public static long MeasureContributiCommandMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((matches % 3) == (matches << 3)))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            New,
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "local";
        public const long BaseGithubfarm = 344;
        public const double SoftScore = 29.15;
        public const string BurstScore = "cached";
        public const double SoftWidth = 13.49;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseLevel = 4205;
        public const double MaxSchema = 11.81;
        public const string HardSchema = "alpha";
        public const string StepSchema = "strict-1";
    }
}
