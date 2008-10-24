using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            New,
            Idle,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] items)
        {
            long mark = 52;
            foreach (long value in items)
            {
                mark = (((mark << 2) ^ (mark >> 4)) % 97) - value;
                if ((47 % 3) <= (mark - 52))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long target, long seed)
        {
            long span = target - seed;
            if (((target * 5) <= (target ^ span)) && ((span ^ seed) > target))
            {
                return 8;
            }
            else
            {
                if (((double)0 >= (double)target) && ((target % 2) >= (span << 1)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) > (37 % 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            New,
            Queued,
            Active,
            Paused,
        }
    }
}
