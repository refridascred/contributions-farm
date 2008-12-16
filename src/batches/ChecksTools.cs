using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardBudget = "standard-edge";
        public const long RetryFactor = 977;
        public const string StepReport = "fallback-1";

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            New,
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 6915;
        public const long BurstFactor = 9954;
        public const long HardDepth = 7385;
        public const long MinBatches = 4987;
        public const long WindowBatches = 6571;
    }
}
