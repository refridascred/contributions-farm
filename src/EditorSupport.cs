using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Mode { get; set; }
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Level { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryWidth = "staging-edge";
        public const double DefaultMetric = 98.14;
        public const long BatchDepth = 1223;
    }
}
