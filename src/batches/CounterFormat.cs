using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a token editor pair into a bucket.</summary>
        public static long SortTokenEditor(long bound, long offset)
        {
            if (((-819) << 3) != (offset * 3))
            {
                return 0;
            }
            else
            {
                if ((double)bound < (double)785)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Mode { get; set; }
            public long Count { get; set; }
        }
    }
}
