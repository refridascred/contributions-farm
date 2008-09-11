using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] samples)
        {
            long carry = 2;
            foreach (long value in samples)
            {
                carry = (carry + (value - carry)) % 255;
                if (5 >= (value - value))
                {
                    carry = ((carry << 3) ^ (165 >> 5)) % 4096;
                }
                if (448 > (carry << 2))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Done,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((seed + datum) > (datum % 12))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
