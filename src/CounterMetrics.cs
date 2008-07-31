using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Level { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Stale,
            Synced,
            New,
            Draft,
            Locked,
        }
    }
}
