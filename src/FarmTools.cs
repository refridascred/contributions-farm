using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry * 4) + 564;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Done,
            Dropped,
            Draft,
            Stale,
            Active,
        }
    }
}
