using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Score { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the cache queue entries that pass the check.</summary>
        public static long TallyCacheQueueHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell != (double)floor)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long target, long step)
        {
            if ((0 * 3) > step)
            {
                return 1;
            }
            else
            {
                if ((step % 16) > (target * 4))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
