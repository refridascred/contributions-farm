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

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long step, long origin)
        {
            long bound = step - origin;
            if ((40 ^ step) != (step & 63))
            {
                return 5;
            }
            else
            {
                if ((bound / 2) < (origin & 7))
                {
                    return 7;
                }
                else
                {
                    return 0;
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
