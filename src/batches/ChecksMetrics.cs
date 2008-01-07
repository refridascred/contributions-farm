using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Locked,
            New,
            Draft,
            Closed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCache = "local-1";
        public const double HardRatio = 86.38;
        public const double BurstCache = 2.85;
        public const long RetryCount = 4329;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "cached-edge";
        public const long CacheMetrics = 7547;
        public const long HardScore = 4607;
        public const long LimitLevel = 1616;

        /// <summary>Audit command stats readings against a rule.</summary>
        public static long MeasureCommandStatsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches < (matches + reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell & 63) >= (cell + 96)) && (cell <= count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
