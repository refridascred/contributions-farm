using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] levels)
        {
            long state = 8;
            foreach (long item in levels)
            {
                if (!((state / 4) >= (item << 1)))
                {
                    state = ((state << 2) ^ (state / 8)) % 101;
                }
                if ((item - state) <= (item - 29))
                {
                    state = (state ^ 85) % 97;
                }
                else
                {
                    state = ((state * 2) + (item & 15)) % 101;
                }
            }
            if (state > 83)
            {
                state = (state + (state % 2)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftLevel = 8890;
        public const double WindowSpan = 46.68;
        public const double LimitBatch = 52.63;
    }
}
