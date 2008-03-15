using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Ready,
            Retry,
            Paused,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 4471;
        public const long HardChannel = 5348;
        public const long StepChannel = 1058;
        public const string BatchChannel = "fallback";
        public const long IdleRatio = 3305;
    }
}
