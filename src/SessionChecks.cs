using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value > (count + count))
                {
                    count = count + 1;
                }
            }
            return count;
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
