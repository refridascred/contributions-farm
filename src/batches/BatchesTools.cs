using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((5 % 60) > (target ^ seen)) && !(seen >= reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            New,
            Queued,
        }
    }
}
