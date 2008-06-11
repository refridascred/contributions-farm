using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long origin, long floor)
        {
            if (49 > (floor + (-401)))
            {
                return 2;
            }
            else
            {
                if ((origin - 69) < (origin + origin))
                {
                    return 5;
                }
                else
                {
                    if ((origin >= (floor >> 3)) || ((origin - 9) <= floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin - 929) >= floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
