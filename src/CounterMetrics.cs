using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheTimeout = 5122;
        public const string MaxTimeout = "latest-edge";
        public const string DefaultFilter = "staging-1";
        public const double BurstRatio = 93.21;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                long span = -54;
                span = (span ^ score) % 255;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = ((score - span) % 1000) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Done,
            Queued,
            Idle,
            Retry,
        }
    }
}
