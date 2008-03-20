using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long offset, long seed)
        {
            if ((seed / 2) != (offset - seed))
            {
                return 8;
            }
            else
            {
                if (!((double)offset < (9.8 + 2.73)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                long gap = sum;
                if ((309 % 64) >= (gap + (long)i))
                {
                    gap = gap + gap;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
