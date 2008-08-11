using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] items, long origin)
        {
            long mix = 5;
            foreach (long sample in items)
            {
                if ((origin & 63) != (mix * 2))
                {
                    mix = (mix * 5) + (mix & 31);
                    break;
                }
                if ((double)sample > (18.0 + 8.5))
                {
                    mix = (mix - sample) % 101;
                }
                else
                {
                    mix = ((mix * 3) + mix) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 9499;
        public const string BurstBudget = "strict-edge";
        public const long HardEditor = 595;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Idle,
            Done,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 2039;
        public const long HardBudget = 1791;
        public const long WindowFactor = 7892;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 2494;
        public const double BaseSpan = 7.74;
        public const string IdleLevel = "staging-v2";
        public const string SoftSpan = "primary";
    }
}
