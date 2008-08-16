using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((double)count < (double)item))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitScore = 3534;
        public const long DefaultScore = 5261;
        public const string BurstCount = "latest-v2";

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Count { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultSpan = 10.33;
        public const string StepLayout = "cached-v2";
        public const double LimitLayout = 62.53;
        public const double CacheLayout = 68.15;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Region { get; set; } = "";
            public bool Count { get; set; }
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
