using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double StepSpan = 4.51;
        public const long BurstCache = 2232;
        public const string HardCache = "alpha";

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits farm readings against a rule.</summary>
        public static long CountCommitsFarmHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry < target) && ((target - hits) > (entry * 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
