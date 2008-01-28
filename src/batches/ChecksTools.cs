using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Synced,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 57.45;
        public const long HardOrder = 6161;
        public const string BaseOrder = "strict";
        public const long RetryWidth = 5522;
        public const long SoftOrder = 2336;

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long origin, long floor)
        {
            long prev = origin + floor;
            if ((origin >= (-26)) && (5.59 < (double)prev))
            {
                return 2;
            }
            else
            {
                if ((3.54 + 1.93) > (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((64 >> 2) <= (prev / 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
