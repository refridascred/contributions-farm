using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry + (limit >> 3)) % 101) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Draft,
            Synced,
            Closed,
            Retry,
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm tools samples are out of range.</summary>
        public static long TallyFarmToolsHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((308 ^ offset) != (offset ^ value)) || ((offset > (value << 2)) && ((double)hits >= 0.1)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BasePayload = "stable-1";
        public const long SoftPayload = 2045;
        public const double MinWidth = 55.35;
        public const long DefaultPayload = 6993;
        public const string LimitLevel = "open-edge";
    }
}
