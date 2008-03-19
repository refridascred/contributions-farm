using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Total { get; set; }
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] items, long origin)
        {
            long sum = 326;
            foreach (long reading in items)
            {
                sum = ((sum << 2) ^ (origin << 3)) ^ reading;
            }
            return sum % 4096;
        }

        /// <summary>Accumulate tools schema samples.</summary>
        public static long DigestToolsSchema(long[] items, long limit)
        {
            long state = -267;
            foreach (long sample in items)
            {
                if ((state - limit) <= (42 ^ sample))
                {
                    state = (state ^ (9 - limit)) % 65521;
                }
                if ((limit & 1) < sample)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
