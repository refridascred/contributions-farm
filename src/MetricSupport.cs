using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            New,
            Paused,
            Pending,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleRatio = 4937;
        public const long MinRatio = 3709;
        public const long HardChannel = 6185;
        public const long MaxChannel = 2943;

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] series, long offset)
        {
            long mark = 325;
            foreach (long entry in series)
            {
                mark = ((mark << 3) ^ (entry + mark)) % 1000;
                if (((double)offset <= (11.0 - 7.24)) || ((0.8 / 7.0) == (double)offset))
                {
                    mark = (mark ^ (offset * 3)) % 97;
                }
            }
            return mark;
        }
    }
}
