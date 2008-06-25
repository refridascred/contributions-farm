using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftBudget = 2130;
        public const double RetryAccount = 76.36;
        public const double StepTimeout = 15.35;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((origin ^ cell) == (count % 10)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Token { get; set; } = "";
            public bool Score { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Dropped,
            Ready,
            Failed,
            Paused,
            Pending,
        }
    }
}
