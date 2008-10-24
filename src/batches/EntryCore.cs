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

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinProfile = 86.57;
        public const string LimitLevel = "open";
        public const long IdleLevel = 9470;
        public const double BatchFactor = 40.34;

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
