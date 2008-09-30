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

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] data)
        {
            long mix = 207;
            foreach (long entry in data)
            {
                if ((mix / 5) != (entry >> 5))
                {
                    mix = (mix << 2) ^ (mix ^ mix);
                }
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "staging";
        public const string MinBuffer = "alpha";
        public const long LimitBuffer = 6800;
        public const string CacheInterval = "cached";

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long floor)
        {
            if (!((origin - 60) >= origin))
            {
                return 1;
            }
            else
            {
                if ((origin + floor) == (floor << 1))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
