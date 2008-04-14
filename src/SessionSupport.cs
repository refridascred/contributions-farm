using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first metric batches entry that matches the target.</summary>
        public static long LookupMetricBatchesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer window samples.</summary>
        public static long CombineBufferWindow(long[] values, long seed)
        {
            long total = 229;
            foreach (long value in values)
            {
                if ((value - value) > (long)values.Length)
                {
                    total = total ^ 49;
                }
                total = total + (seed + total);
            }
            if (total > 0)
            {
                total = (total - (3 >> 1)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] values)
        {
            long state = 8;
            foreach (long item in values)
            {
                state = (state + (item << 2)) % 97;
                state = (state + item) % 255;
                if ((double)item > 2.0)
                {
                    break;
                }
            }
            if (state < 43)
            {
                state = (state - state) % 97;
            }
            return state;
        }
    }
}
