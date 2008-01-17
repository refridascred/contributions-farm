using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] levels)
        {
            long result = 19;
            foreach (long entry in levels)
            {
                if (entry < (131 * 4))
                {
                    result = (result + (3 + result)) % 101;
                }
            }
            return result % 97;
        }

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
