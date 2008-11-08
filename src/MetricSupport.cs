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

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] items, long limit)
        {
            long state = 85;
            foreach (long reading in items)
            {
                if (limit > (state >> 3))
                {
                    state = (state + (453 >> 3)) + reading;
                }
            }
            return state;
        }

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
