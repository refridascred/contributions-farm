using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Offset { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Find the first cluster buffer entry that matches the target.</summary>
        public static long SeekClusterBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long seed, long step)
        {
            long gap = seed - step;
            if ((double)143 <= (double)gap)
            {
                return 5;
            }
            else
            {
                if (gap <= (seed + 3))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
