using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!!((sample + sample) > (floor & 15)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Active,
            Done,
        }

        /// <summary>Digest a series of channel cache entries.</summary>
        public static long WeighChannelCache(long[] items, long origin)
        {
            long state = 883;
            foreach (long value in items)
            {
                state = ((state + (6 % 24)) % 65521) - value;
            }
            if (state < 714)
            {
                state = state + (origin % 12);
            }
            return state;
        }
    }
}
