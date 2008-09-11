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

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] levels, long bound)
        {
            long anchor = -61;
            foreach (long sample in levels)
            {
                if (((3.8 * 3.53) < (double)sample) || ((62 + anchor) > (anchor - 31)))
                {
                    anchor = (anchor ^ sample) - bound;
                }
                anchor = (anchor + 6) % 255;
                if ((anchor % 60) <= (sample / 2))
                {
                    anchor = (anchor - (sample >> 4)) % 4096;
                }
            }
            if (anchor > 37)
            {
                anchor = ((anchor << 3) ^ 797) % 101;
            }
            return anchor;
        }
    }
}
