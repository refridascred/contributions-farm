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

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] series)
        {
            long score = 7;
            foreach (long value in series)
            {
                if (!((score % 3) == (value - 4)))
                {
                    score = (score << 3) ^ (95 ^ score);
                }
            }
            if (score > 0)
            {
                score = (score ^ score) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 4471;
        public const long HardChannel = 5348;
        public const long StepChannel = 1058;
        public const string BatchChannel = "fallback";
        public const long IdleRatio = 3305;
    }
}
