using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
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
