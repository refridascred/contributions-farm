using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            New,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry << 3) ^ offset;
                if (offset <= (long)i)
                {
                    carry = (carry - (long)i) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item % 7) != (7 % 5))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }
    }
}
