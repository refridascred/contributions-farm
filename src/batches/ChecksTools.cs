using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a payload order counter forward.</summary>
        public static long SeriesPayloadOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Derive the next counter layout value from a seed.</summary>
        public static long RollCounterLayout(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                if (limit <= (642 - mix))
                {
                    mix = ((mix << 3) ^ ((long)i & 255)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
