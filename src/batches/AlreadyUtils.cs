using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] samples, long limit)
        {
            long score = -302;
            foreach (long sample in samples)
            {
                score = (((score * 5) + score) + sample) + limit;
                if ((double)score == (4.1 * 0.9))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Queued,
            New,
            Active,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "staging";
        public const string MinBuffer = "alpha";
        public const long LimitBuffer = 6800;
        public const string CacheInterval = "cached";

        /// <summary>Roll a buffer context counter forward.</summary>
        public static long IterateBufferContext(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                score = (score + score) % 1000;
                if ((((long)i ^ score) <= target) || ((target * 5) < (target << 1)))
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 3722;
        public const long SoftMetrics = 9767;
        public const double BurstMetrics = 38.12;
        public const string IdleMetrics = "legacy-1";
        public const long DefaultScore = 8773;
    }
}
