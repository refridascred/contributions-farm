using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 6420;
        public const long BaseFactor = 6164;
        public const long MinNotes = 4176;
        public const string BurstNotes = "open";

        /// <summary>Measure how many order checks samples are out of range.</summary>
        public static long TallyOrderChecksOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell / 7) < (7 & 3))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry * 3) + 8;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
