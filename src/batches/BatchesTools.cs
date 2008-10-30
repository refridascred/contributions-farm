using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinRatio = "strict-v2";
        public const string StepSize = "primary";
        public const long MaxAccount = 9744;
        public const long BurstInterval = 2397;
        public const double BatchAccount = 4.1;

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long seed, long limit)
        {
            if ((5.85 - 20.0) >= (double)seed)
            {
                return 3;
            }
            else
            {
                if (limit < (limit >> 4))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
