using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit cluster already readings against a rule.</summary>
        public static long MeasureClusterAlreadyMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((2.1 * 7.8) != (double)bound)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 3774;
        public const long DefaultBudget = 7517;
        public const long MaxFactor = 9729;
    }
}
