using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((963 + matches) == (target & 15))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            New,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Queued,
            Done,
            Failed,
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Rank { get; set; }
            public double Label { get; set; }
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
