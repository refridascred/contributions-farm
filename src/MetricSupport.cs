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

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] samples)
        {
            long total = 804;
            foreach (long item in samples)
            {
                total = ((total + total) % 97) + item;
            }
            return total % 1000;
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
