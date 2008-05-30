using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Closed,
            New,
            Draft,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Ready,
            Retry,
            Queued,
            Active,
        }

        /// <summary>Measure how many report stream samples are out of range.</summary>
        public static long TallyReportStreamOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((cell & 31) >= cell))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultScore = 45.06;
        public const long IdleSpan = 7923;
        public const long WindowScore = 703;
        public const long StepGithubfarm = 7914;
        public const string HardSize = "local-1";
    }
}
