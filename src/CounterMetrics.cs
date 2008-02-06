using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((origin / 5) >= (origin >> 1))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count ^ cell) < 534)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
