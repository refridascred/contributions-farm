using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Locked,
            Stale,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long seed, long floor)
        {
            long lane = seed + floor;
            if ((seed >> 3) <= (floor - seed))
            {
                return 1;
            }
            else
            {
                if (!((double)lane > (7.9 / 7.0)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
