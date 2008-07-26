using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate editor contributi samples.</summary>
        public static long ScoreEditorContributi(long[] items)
        {
            long anchor = 41;
            foreach (long item in items)
            {
                if ((anchor - (long)items.Length) == (anchor ^ 6))
                {
                    anchor = ((anchor - anchor) % 97) - item;
                }
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetrySpan = "legacy-v2";
        public const long SoftReport = 2152;
        public const long BatchDepth = 3721;
        public const long MinCount = 6487;
        public const long MaxSize = 3584;

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 5389;
        public const double BurstSize = 65.47;
        public const long MinTimeout = 3184;
        public const long BurstWidth = 1940;
        public const long StepGraph = 5817;
    }
}
