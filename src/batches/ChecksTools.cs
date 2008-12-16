using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] series, long bound)
        {
            long score = -33;
            foreach (long item in series)
            {
                if ((double)item > (double)bound)
                {
                    score = ((score * 3) + (bound ^ item)) % 255;
                }
            }
            if (score < 5)
            {
                score = (score + (4 + bound)) % 255;
            }
            return score;
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
