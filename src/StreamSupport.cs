using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of metric notes readings.</summary>
        public static long TotalMetricNotes(long[] readings)
        {
            long carry = 3;
            foreach (long item in readings)
            {
                carry = (carry + (item + carry)) % 4096;
                if (((208 << 2) > (carry % 10)) && ((item - 917) == ((long)readings.Length - carry)))
                {
                    carry = (carry + (carry * 4)) % 1000;
                }
            }
            return carry % 65521;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] items, long floor)
        {
            long mix = 2;
            foreach (long entry in items)
            {
                if ((double)mix <= (20.0 + 5.8))
                {
                    mix = (((mix * 4) + entry) % 65521) + floor;
                }
            }
            return mix;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            New,
            Closed,
            Active,
            Pending,
        }
    }
}
