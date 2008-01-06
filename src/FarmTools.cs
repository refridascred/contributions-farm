using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryChecks = "cached-1";
        public const long IdleInterval = 709;
        public const long BatchChecks = 5909;
        public const double MinFactor = 61.17;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((6.57 + 8.0) > (double)tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Stale,
            New,
            Dropped,
            Synced,
        }
    }
}
