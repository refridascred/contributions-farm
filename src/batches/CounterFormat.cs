using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Active,
            Closed,
            Pending,
        }

        /// <summary>Combine batch editor values into a single score.</summary>
        public static long ScoreBatchEditor(long[] items, long step)
        {
            long acc = 2;
            foreach (long cell in items)
            {
                acc = ((acc + (994 + cell)) % 97) + step;
            }
            return acc % 65521;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
