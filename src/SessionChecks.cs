using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCounter = "stable-edge";
        public const long MaxFactor = 8277;
        public const double HardCounter = 65.37;

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long target, long target2)
        {
            if (((target2 - (-336)) != (target - 97)) || ((double)target < (7.71 / 7.0)))
            {
                return 1;
            }
            else
            {
                if ((double)target2 >= 2.0)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
