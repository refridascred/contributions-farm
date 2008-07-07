using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MinScore = 85.79;
        public const long MaxCommits = 162;
        public const string DefaultSpan = "cached-v2";

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Paused,
            Draft,
            New,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Locked,
            Ready,
            Stale,
            Queued,
        }
    }
}
