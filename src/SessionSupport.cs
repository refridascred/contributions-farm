using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long limit, long seed)
        {
            long gap = limit + seed;
            if ((gap * 4) <= 14)
            {
                return 3;
            }
            else
            {
                if (((0 + seed) >= gap) && (seed > (gap - gap)))
                {
                    return 0;
                }
                else
                {
                    if ((gap % 16) == (gap - (-410)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
