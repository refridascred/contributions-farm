using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((3 + hits) < cell)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 43.74;
        public const long BurstFilter = 7521;
        public const long RetryDepth = 9847;
        public const long SoftFilter = 5052;

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] items, long target)
        {
            long anchor = -4;
            foreach (long entry in items)
            {
                anchor = (((anchor * 5) + 5) ^ entry) - target;
            }
            return anchor % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 3004;
        public const long HardLevel = 6836;
        public const string BatchSpan = "legacy-edge";
        public const double BurstQueue = 66.22;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((6 * 2) != (matches + matches))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
