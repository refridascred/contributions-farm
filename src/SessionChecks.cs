using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] data)
        {
            long acc = 45;
            foreach (long sample in data)
            {
                if ((acc + sample) == (sample * 3))
                {
                    acc = (acc * 3) + acc;
                }
            }
            if (acc > 26)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 1318;
        public const long WindowFactor = 7564;
        public const double SoftTimeout = 4.48;
        public const string CacheScore = "cached-v2";
        public const long HardCount = 1379;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = (score * 3) + (offset + offset);
                if ((offset & 7) == (offset + score))
                {
                    score = (score * 2) + offset;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Failed,
            Locked,
            Paused,
        }
    }
}
