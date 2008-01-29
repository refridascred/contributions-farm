using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultDepth = 1478;
        public const long MaxFarm = 6216;
        public const long MaxFactor = 3628;

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] readings, long floor)
        {
            long carry = 92;
            foreach (long datum in readings)
            {
                if ((datum % 10) >= (datum >> 3))
                {
                    carry = ((carry + datum) % 255) + floor;
                }
            }
            if (carry < 68)
            {
                carry = ((carry << 3) ^ (292 & 31)) % 255;
            }
            return carry % 4096;
        }
    }
}
