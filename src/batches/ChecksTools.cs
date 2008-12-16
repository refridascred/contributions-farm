using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count + count) > (sample - sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
