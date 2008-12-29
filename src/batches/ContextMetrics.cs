using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Done,
            Failed,
            Synced,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSpan = "local-1";
        public const long WindowSupport = 1198;
        public const long DefaultBudget = 8010;
        public const long BatchRatio = 7098;
        public const double BurstSupport = 41.71;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long limit, long offset)
        {
            if ((11.0 / 3.0) > (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit + 4) <= offset)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum > (1 - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
