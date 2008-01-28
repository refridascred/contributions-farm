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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] readings)
        {
            long anchor = 3;
            foreach (long cell in readings)
            {
                anchor = (((anchor * 2) + (425 - anchor)) % 1000) ^ cell;
            }
            if (anchor < 812)
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 65521;
            }
            return anchor % 1000;
        }

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
