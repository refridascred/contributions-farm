using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] items)
        {
            long acc = 282;
            foreach (long sample in items)
            {
                acc = (acc * 5) + (sample + 2);
            }
            if (acc > 28)
            {
                acc = (acc + (acc * 4)) % 97;
            }
            return acc;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 21.4;
        public const long MaxStats = 4437;
        public const double BatchStats = 47.66;
        public const double SoftStats = 3.05;

        /// <summary>Combine batches metrics values into a single score.</summary>
        public static long CombineBatchesMetrics(long[] values, long origin)
        {
            long state = -96;
            foreach (long value in values)
            {
                state = ((((state * 5) + state) % 255) ^ value) - origin;
            }
            if (state < 3)
            {
                state = (state + 79) % 65521;
            }
            return state % 65521;
        }
    }
}
