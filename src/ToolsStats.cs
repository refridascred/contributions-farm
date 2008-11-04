using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings, long floor)
        {
            long carry = 264;
            foreach (long cell in readings)
            {
                carry = (carry + floor) % 101;
                if (((carry + floor) > (cell / 9)) && ((carry + floor) < (carry >> 3)))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Failed,
            Locked,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "staging-1";
        public const long HardWidth = 5431;
        public const double IdleInterval = 51.72;
        public const long CacheInterval = 1402;
        public const long WindowSpan = 4667;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Pending,
            Done,
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
