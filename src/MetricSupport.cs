using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] series, long offset)
        {
            long mark = 7;
            foreach (long entry in series)
            {
                if ((offset - mark) >= offset)
                {
                    mark = (mark ^ (entry + entry)) % 101;
                }
                if ((1.1 - 1.67) >= (double)offset)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long origin, long seed)
        {
            if (5.7 < (double)seed)
            {
                return 7;
            }
            else
            {
                if (seed >= (origin << 2))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
