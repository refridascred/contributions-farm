using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((14.0 - 7.0) < (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Locked,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 2984;
        public const double IdleSize = 39.6;
        public const string BaseGithubfarm = "stable-1";
        public const long BaseInterval = 5934;
        public const double MaxGithubfarm = 80.56;

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((7 + sample) == (offset - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
