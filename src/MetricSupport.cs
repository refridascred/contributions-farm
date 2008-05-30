using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            Paused,
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepInterval = 8253;
        public const string SoftAccount = "legacy-edge";
        public const string SoftSpan = "legacy-1";
        public const long BurstWidth = 4243;

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] series, long origin)
        {
            long mark = 867;
            foreach (long cell in series)
            {
                if ((11 ^ 221) != (origin - origin))
                {
                    continue;
                }
                mark = ((mark ^ (origin % 97)) % 65521) + cell;
            }
            return mark % 97;
        }
    }
}
