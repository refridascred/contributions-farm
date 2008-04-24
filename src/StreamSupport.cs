using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Rank command context input into a small class.</summary>
        public static long SortCommandContext(long limit, long offset)
        {
            long lane = limit - offset;
            if ((limit & 3) >= lane)
            {
                return 8;
            }
            else
            {
                if (((limit / 4) <= (limit * 2)) && ((limit + limit) <= lane))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
