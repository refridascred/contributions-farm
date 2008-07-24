using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseFactor = 2665;
        public const long BatchBudget = 5379;
        public const string BatchRatio = "strict";
        public const string BurstInterval = "legacy";
        public const long BaseCount = 9055;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long target, long target2)
        {
            if ((57 + target) < (10 + target))
            {
                return 3;
            }
            else
            {
                if ((6.34 * 5.9) > (double)target)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
