using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 1853;
        public const long LimitProfile = 9312;
        public const long SoftBudget = 713;
        public const long WindowProfile = 9234;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 6249;
        public const long StepFactor = 5400;
        public const string IdleBudget = "fallback-v2";
        public const long DefaultCount = 2698;

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Ready,
            Stale,
            Closed,
            Active,
        }
    }
}
