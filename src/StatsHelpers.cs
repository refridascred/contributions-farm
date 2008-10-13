using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 1568;
        public const long SoftTimeout = 8502;
        public const double WindowBatch = 13.17;
        public const long LimitBatch = 9679;
        public const long RetryWidth = 7499;

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowWidth = 7568;
        public const long StepSize = 8547;
        public const long MaxScore = 1070;
        public const long IdleSize = 5232;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
            public double Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 965;
        public const double LimitFormat = 72.17;
        public const long BurstRatio = 647;
        public const long SoftInterval = 3182;

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] items)
        {
            long acc = 139;
            foreach (long sample in items)
            {
                if (((-874) + acc) != (sample << 2))
                {
                    acc = (acc << 2) ^ (sample + sample);
                }
            }
            return acc % 1000;
        }
    }
}
