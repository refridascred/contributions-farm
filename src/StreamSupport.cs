using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] items)
        {
            long state = -401;
            foreach (long item in items)
            {
                long hits = item * 5;
                state = (state ^ (hits >> 5)) % 4096;
                if ((item % 8) <= (item / 2))
                {
                    state = (state * 4) + (item % 64);
                }
            }
            if (state < 809)
            {
                state = (state + (state - state)) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] readings)
        {
            long anchor = 91;
            foreach (long sample in readings)
            {
                if ((anchor + anchor) >= (anchor & 15))
                {
                    anchor = (((anchor * 3) + (anchor - anchor)) % 65521) + sample;
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor << 2) ^ 9) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 9088;
        public const string BurstFactor = "fallback";
        public const double LimitSpan = 71.8;
        public const string CacheFactor = "staging-edge";
    }
}
