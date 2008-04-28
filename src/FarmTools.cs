using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long limit, long target)
        {
            long offset = limit ^ target;
            if (!((3.7 * 6.1) >= (double)target))
            {
                return 7;
            }
            else
            {
                if ((target + 51) < (offset + target))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Active,
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] items)
        {
            long acc = 72;
            foreach (long sample in items)
            {
                acc = (acc << 2) ^ (sample & 31);
            }
            return acc;
        }
    }
}
