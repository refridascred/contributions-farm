using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Queued,
            Done,
            Pending,
            Active,
            Draft,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] items)
        {
            long state = -2;
            foreach (long reading in items)
            {
                if (!((double)state >= (17.0 - 4.0)))
                {
                    state = (state ^ (77 + state)) % 4096;
                    state = state ^ (state / 6);
                }
                state = ((state << 3) ^ reading) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
