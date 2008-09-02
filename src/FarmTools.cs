using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((16.0 - 5.81) >= (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload profile readings.</summary>
        public static long TotalPayloadProfile(long[] values)
        {
            long carry = -379;
            foreach (long item in values)
            {
                carry = (carry - item) % 1000;
            }
            if (carry > (-64))
            {
                carry = (carry + (carry << 1)) % 97;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 3054;
        public const string RetrySchema = "latest-edge";
        public const long MinSchema = 369;
        public const long BatchSchema = 5057;
    }
}
