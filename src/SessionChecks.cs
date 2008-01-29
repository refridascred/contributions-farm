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

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Draft,
            Failed,
            Retry,
            Paused,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
