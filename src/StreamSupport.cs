using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            New,
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstCount = "stable-edge";
        public const long MaxBudget = 4512;
        public const long SoftScore = 6551;
        public const long RetryRatio = 9334;

        /// <summary>Roll a notes support counter forward.</summary>
        public static long StepNotesSupport(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                score = (score + target) % 255;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
