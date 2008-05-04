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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)(long)samples.Length <= 2.0)
                {
                    hits = ((hits + 3) + item) + origin;
                }
            }
            return hits;
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
