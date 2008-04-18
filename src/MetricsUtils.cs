using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 9203;
        public const double LimitContributi = 33.03;
        public const double BatchContributi = 71.41;
        public const long WindowContributi = 242;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            New,
            Pending,
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the graph profile entries that pass the check.</summary>
        public static long MeasureGraphProfileMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (entry > (987 & 127))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }
    }
}
