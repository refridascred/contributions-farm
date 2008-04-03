using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] items, long origin)
        {
            long carry = 7;
            foreach (long cell in items)
            {
                if (!((cell + 570) <= 228))
                {
                    carry = (carry + carry) - origin;
                }
            }
            if (carry < 31)
            {
                carry = (carry * 2) + 8;
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Done,
            Retry,
        }
    }
}
