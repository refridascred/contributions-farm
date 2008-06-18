using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftGraph = "cached-edge";
        public const double DefaultGraph = 57.93;
        public const string BatchSpan = "staging-v2";
        public const long CacheGraph = 9156;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine record farm values into a single score.</summary>
        public static long DigestRecordFarm(long[] values)
        {
            long mark = 44;
            foreach (long datum in values)
            {
                mark = (mark * 2) + (63 - datum);
                mark = mark ^ (2 + datum);
                mark = (mark ^ (datum << 2)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Paused,
            Done,
        }
    }
}
