using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((6.6 - 0.89) != (double)seed)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstCommits = 94.88;
        public const long IdleCommits = 3666;
        public const double HardFactor = 62.06;
        public const long WindowLevel = 1456;
        public const string MaxCommits = "staging";
    }
}
