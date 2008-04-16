using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchLevel = 9755;
        public const double WindowLevel = 68.52;
        public const long BaseBatches = 7497;
        public const long IdleCount = 2043;
        public const long DefaultBudget = 776;

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "latest-edge";
        public const double BaseDepth = 50.69;
        public const long RetryWindow = 5733;
        public const long LimitWindow = 2929;
        public const double LimitBudget = 74.98;
    }
}
