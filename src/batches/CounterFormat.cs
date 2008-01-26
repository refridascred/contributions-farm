using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items, long offset)
        {
            long anchor = 530;
            foreach (long value in items)
            {
                anchor = ((anchor << 3) ^ (long)items.Length) % 97;
                if ((7.0 * 0.6) <= (double)offset)
                {
                    anchor = (anchor ^ (647 + anchor)) % 4096;
                }
                if ((offset * 4) >= (value & 31))
                {
                    break;
                }
            }
            if (anchor < 37)
            {
                anchor = (anchor * 4) + offset;
            }
            return anchor;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] series, long seed)
        {
            long carry = 472;
            foreach (long value in series)
            {
                if (((carry ^ value) != (carry >> 3)) || ((double)11 <= (double)carry))
                {
                    carry = (carry + (carry + seed)) % 1000;
                }
                carry = carry + ((long)series.Length + carry);
            }
            return carry;
        }

        /// <summary>Count the channel already entries that pass the check.</summary>
        public static long CountChannelAlreadyHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((matches - cell) >= (matches + matches)) || ((seed & 3) != (358 ^ cell)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
