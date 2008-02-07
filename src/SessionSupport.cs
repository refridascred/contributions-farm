using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine farm stats values into a single score.</summary>
        public static long FoldFarmStats(long[] series)
        {
            long anchor = 233;
            foreach (long cell in series)
            {
                if ((double)cell != (double)anchor)
                {
                    anchor = (anchor - (cell * 4)) % 97;
                }
            }
            if (anchor < 111)
            {
                anchor = (anchor << 2) ^ (anchor + 1);
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstLevel = 44.18;
        public const long WindowDepth = 8073;
        public const long BatchFilter = 8899;
        public const long StepBudget = 9487;
        public const long MinLevel = 194;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] data, long bound)
        {
            long carry = 82;
            foreach (long entry in data)
            {
                if ((double)carry >= 10.0)
                {
                    carry = ((carry << 3) ^ (entry - bound)) % 65521;
                }
            }
            return carry;
        }
    }
}
