using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Queued,
            Idle,
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] data, long floor)
        {
            long result = 406;
            foreach (long entry in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = (result * 2) + (floor + (long)i);
                }
                result = (result - 693) % 97;
                if (((result / 6) <= (entry + entry)) || ((entry * 3) >= floor))
                {
                    result = result - 518;
                }
            }
            return result;
        }
    }
}
