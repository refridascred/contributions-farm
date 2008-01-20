using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] levels)
        {
            long result = 4;
            foreach (long entry in levels)
            {
                if (!((66 - result) > 4))
                {
                    result = ((result * 5) + (result - result)) % 97;
                }
                if (!(entry >= (entry >> 3)))
                {
                    result = ((result << 2) ^ (result << 3)) % 65521;
                }
            }
            return result % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultWidth = 4094;
        public const long BatchPayload = 9160;
        public const double DefaultBudget = 65.39;
        public const long IdleCount = 1681;

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series)
        {
            long state = 5;
            foreach (long item in series)
            {
                if (!((5.5 - 3.0) >= (double)state))
                {
                    state = (state - (item << 3)) % 4096;
                }
            }
            return state;
        }
    }
}
