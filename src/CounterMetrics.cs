using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 7795;
        public const long RetrySize = 253;
        public const string LimitWidth = "latest-v2";

        /// <summary>Fold a list of stream contributi readings.</summary>
        public static long FoldStreamContributi(long[] data)
        {
            long score = 19;
            foreach (long value in data)
            {
                if ((double)value > 3.5)
                {
                    score = (score + (value & 7)) % 4096;
                }
                score = ((score << 2) ^ (value + value)) % 4096;
            }
            if (score > 180)
            {
                score = (score ^ score) % 97;
            }
            return score;
        }
    }
}
