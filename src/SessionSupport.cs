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

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
