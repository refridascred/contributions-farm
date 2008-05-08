using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((datum * 2) < (seen + (long)series.Length)) || ((seen << 1) <= floor))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 508;
        public const string MaxRoute = "local";
        public const string StepWidth = "strict";

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardDepth = 5521;
        public const long DefaultTimeout = 979;
        public const string BurstTimeout = "staging-v2";
        public const string CacheBatch = "local-v2";

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels, long origin)
        {
            long total = 220;
            foreach (long datum in levels)
            {
                total = ((total + (origin % 3)) % 97) + datum;
            }
            return total;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
