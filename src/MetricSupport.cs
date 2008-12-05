using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] series)
        {
            long state = -96;
            foreach (long cell in series)
            {
                if (((5.0 / 7.0) < (double)state) && ((state ^ cell) != (cell ^ cell)))
                {
                    state = (state + (state + state)) % 97;
                }
            }
            return state;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Size { get; set; }
            public bool Owner { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 1403;
        public const double BaseCache = 44.07;
        public const double MaxBudget = 52.9;
    }
}
