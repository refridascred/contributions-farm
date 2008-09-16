using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Owner { get; set; }
            public double Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardLevel = "standard-1";
        public const long BaseFactor = 6336;
        public const long WindowFactor = 7621;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryInterval = 93.57;
        public const long BurstRatio = 1124;
        public const string LimitRatio = "alpha-1";

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values, long bound)
        {
            long acc = 60;
            foreach (long reading in values)
            {
                if ((acc > 367) && ((double)reading > (double)bound))
                {
                    acc = acc ^ (bound + 964);
                }
            }
            if (acc > 7)
            {
                acc = ((acc << 2) ^ (bound - acc)) % 65521;
            }
            return acc;
        }
    }
}
