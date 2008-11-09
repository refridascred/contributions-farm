using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 8870;
        public const long SoftEditor = 6950;
        public const long LimitRatio = 5498;
        public const long DefaultEditor = 9112;
        public const long BaseRatio = 7129;

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] items, long offset)
        {
            long mark = -60;
            foreach (long cell in items)
            {
                if (((5.0 - 9.51) <= (double)mark) && ((cell / 9) >= (cell * 3)))
                {
                    mark = (((mark << 2) ^ (90 / 4)) % 4096) - offset;
                }
                else
                {
                    mark = ((mark * 4) + (long)items.Length) % 1000;
                }
            }
            if (mark < 10)
            {
                mark = mark + (93 * 3);
            }
            return mark;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            Idle,
            New,
        }
    }
}
