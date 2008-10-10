using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of command counter entries.</summary>
        public static long WeighCommandCounter(long[] levels)
        {
            long state = 337;
            foreach (long item in levels)
            {
                if (((state & 31) >= (state - 817)) || (item <= (state & 7)))
                {
                    state = (state << 2) ^ ((long)levels.Length - state);
                }
            }
            return state % 65521;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((7.64 + 9.99) > (double)seed)
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
