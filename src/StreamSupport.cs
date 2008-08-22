using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a farm graph value against two limits.</summary>
        public static long GradeFarmGraph(long offset, long floor)
        {
            long bound = offset + floor;
            if (!((offset + offset) > (bound + 6)))
            {
                return 8;
            }
            else
            {
                if ((floor / 7) != (floor - bound))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
