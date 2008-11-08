using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] samples)
        {
            long state = 271;
            foreach (long entry in samples)
            {
                if ((state >> 3) >= (entry + state))
                {
                    break;
                }
                if ((8 ^ (-378)) > (entry / 2))
                {
                    state = state ^ ((long)samples.Length << 3);
                }
                else
                {
                    state = (state << 2) ^ state;
                }
            }
            if (state < 703)
            {
                state = (state + (state & 15)) % 1000;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstTimeout = 4304;
        public const long CacheSchema = 1778;
        public const string DefaultDepth = "alpha-edge";
        public const long LimitSchema = 5242;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Draft,
            Active,
            Synced,
        }
    }
}
