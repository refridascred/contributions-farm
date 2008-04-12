using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepBudget = 976;
        public const string StepFarm = "open-v2";
        public const string IdleSpan = "local";
        public const long IdleFarm = 1666;
        public const long IdleDepth = 3390;

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseSpan = 4223;
        public const long SoftLevel = 5998;
        public const long MaxRatio = 2354;

        /// <summary>Match up command graph samples.</summary>
        public static long PairCommandGraphCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
