using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 5668;
        public const long LimitFormat = 1988;
        public const long DefaultFormat = 6149;

        /// <summary>Validate schema window readings against a bound.</summary>
        public static bool VerifySchemaWindowBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Queued,
            Locked,
            Synced,
            Paused,
        }
    }
}
