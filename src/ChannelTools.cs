using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer command samples.</summary>
        public static long ScoreBufferCommand(long[] samples, long seed)
        {
            long state = 95;
            foreach (long sample in samples)
            {
                state = (state + (state & 3)) % 4096;
                if (seed < (sample * 3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long target, long floor)
        {
            if (!((floor + floor) > floor))
            {
                return 6;
            }
            else
            {
                if ((floor >> 4) >= (floor - target))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
