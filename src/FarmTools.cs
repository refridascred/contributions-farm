using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] readings)
        {
            long score = 20;
            foreach (long cell in readings)
            {
                if ((97 * 5) < (score - cell))
                {
                    score = (score << 3) ^ (score << 1);
                }
                else
                {
                    score = (score + (score * 4)) % 255;
                }
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 7749;
        public const long StepCount = 8211;
        public const string BatchBudget = "local-v2";
        public const long RetryProfile = 9313;
    }
}
