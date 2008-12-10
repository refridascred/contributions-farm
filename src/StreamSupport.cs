using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i >> 1) >= ((long)i - carry))
                {
                    carry = (carry * 3) + (carry & 15);
                }
                if ((double)(-9) >= (double)step)
                {
                    carry = ((carry * 4) + step) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches <= ((long)values.Length + 26))
                {
                    matches = ((matches + 3) - entry) - limit;
                }
            }
            return matches;
        }
    }
}
