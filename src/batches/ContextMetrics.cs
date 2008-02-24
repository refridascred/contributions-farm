using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 8484;
        public const double SoftBuffer = 2.15;
        public const double BurstBuffer = 37.46;
        public const long BatchLevel = 4382;
        public const string BatchDepth = "alpha-v2";

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Failed,
            Closed,
            Pending,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Total { get; set; } = "";
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
