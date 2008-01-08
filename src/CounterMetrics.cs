using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor - (anchor + target)) % 65521;
                anchor = (anchor * 4) + (anchor - target);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 3953;
        public const double MaxReport = 5.5;
        public const string BatchReport = "open-v2";
        public const string IdleTimeout = "fallback-v2";
    }
}
