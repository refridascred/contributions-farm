using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a tools payload counter forward.</summary>
        public static long DeriveToolsPayload(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry << 2) ^ (floor >> 3);
                carry = (carry + (floor << 1)) % 255;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches - matches) != (floor * 5))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Audit account stream readings against a rule.</summary>
        public static long AuditAccountStreamGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!!(7 < count))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }
    }
}
