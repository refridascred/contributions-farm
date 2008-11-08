using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 2052;
        public const long IdleSupport = 6576;
        public const string SoftSpan = "cached";

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 5230;
        public const double BaseRecord = 78.34;
        public const long CacheRecord = 2089;
        public const long BatchRecord = 5058;

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Level { get; set; }
            public bool Region { get; set; }
        }
    }
}
