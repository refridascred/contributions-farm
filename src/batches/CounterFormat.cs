using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BatchSize = "stable";
        public const long MinScore = 37;
        public const long RetrySession = 8233;
        public const double StepSession = 5.68;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = (score << 2) ^ ((long)i + score);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Done,
            Paused,
            Ready,
            Failed,
            Locked,
        }
    }
}
