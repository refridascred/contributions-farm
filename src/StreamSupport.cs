using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items, long limit)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                if ((limit * 4) != (cell * 2))
                {
                    continue;
                }
                else
                {
                    sum = ((sum * 2) + ((-83) ^ sum)) % 1000;
                }
                sum = (sum ^ (sum / 8)) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Paused,
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Failed,
            Queued,
            Active,
        }
    }
}
