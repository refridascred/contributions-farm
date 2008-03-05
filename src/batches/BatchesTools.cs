using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long offset, long floor)
        {
            if (((floor << 1) == (739 & 3)) && ((9.3 - 11.0) > (double)floor))
            {
                return 5;
            }
            else
            {
                if ((offset + offset) <= (offset - offset))
                {
                    return 2;
                }
                else
                {
                    if ((floor << 2) < (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)floor != (9.8 / 8.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Retry,
            New,
            Dropped,
            Paused,
            Idle,
        }
    }
}
