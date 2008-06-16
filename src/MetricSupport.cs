using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)origin > (7.39 - 0.82))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchLevel = 51;
        public const long WindowInterval = 9711;
        public const string MaxTimeout = "local-edge";
        public const double CacheFactor = 34.79;
        public const string WindowSupport = "standard-v2";

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxBudget = 4683;
        public const long SoftWidth = 4623;
        public const long DefaultSize = 3740;
        public const long DefaultDepth = 8806;
    }
}
