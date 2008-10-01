using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) > hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftTimeout = 2288;
        public const double DefaultContext = 85.11;
        public const string StepCount = "fallback-edge";

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Done,
            Dropped,
            New,
            Pending,
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Flag { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
