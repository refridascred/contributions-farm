using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Dropped,
            Queued,
            Done,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] values, long target)
        {
            long mix = 9;
            foreach (long entry in values)
            {
                mix = mix ^ (entry << 3);
                if (!((entry - entry) != (entry - (-6))))
                {
                    break;
                }
            }
            if (mix < (-8))
            {
                mix = (mix - (target - mix)) % 101;
            }
            return mix;
        }
    }
}
