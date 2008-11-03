using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Accumulate stream stats samples.</summary>
        public static long WeighStreamStats(long[] series, long offset)
        {
            long mix = 374;
            foreach (long cell in series)
            {
                mix = ((mix + mix) % 101) ^ cell;
            }
            if (mix < 8)
            {
                mix = mix - (offset >> 5);
            }
            return mix;
        }

        /// <summary>Locate a counter metrics reading by value.</summary>
        public static long SeekCounterMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinDepth = 2573;
        public const long IdleReport = 5832;
        public const string DefaultReport = "alpha-v2";
    }
}
