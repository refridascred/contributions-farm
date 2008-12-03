using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Pending,
            Ready,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] series, long offset)
        {
            long acc = 4;
            foreach (long cell in series)
            {
                if ((offset * 3) != (acc - 386))
                {
                    acc = (((acc << 2) ^ acc) % 4096) + cell;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc / 4)) % 1000;
                }
            }
            return acc;
        }
    }
}
