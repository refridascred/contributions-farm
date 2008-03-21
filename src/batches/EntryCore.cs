using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many window metric samples are out of range.</summary>
        public static long CountWindowMetricGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches >> 4) <= (83 & 31))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftWidth = 70.07;
        public const long MinSupport = 8600;
        public const long BurstRatio = 29;
        public const long RetrySupport = 6849;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Idle,
            New,
            Ready,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Region { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
