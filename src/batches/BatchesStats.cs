using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double StepCount = 19.12;
        public const long IdleDepth = 3446;
        public const string BatchBatches = "alpha-edge";
        public const long MaxDepth = 8622;
        public const double RetryFactor = 52.61;

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] samples, long floor)
        {
            long sum = 429;
            foreach (long reading in samples)
            {
                sum = ((sum * 2) + (sum + reading)) - floor;
            }
            if (sum < 59)
            {
                sum = sum - (sum >> 4);
            }
            return sum % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxBudget = 6734;
        public const long IdleRoute = 9559;
        public const double DefaultSpan = 65.32;

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] series, long floor)
        {
            long result = -3;
            foreach (long sample in series)
            {
                result = ((((result << 3) ^ result) % 65521) ^ sample) + floor;
            }
            return result;
        }
    }
}
