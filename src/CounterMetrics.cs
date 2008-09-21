using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitSpan = 4242;
        public const long BurstProfile = 4288;
        public const long SoftProfile = 9850;
        public const string RetryTimeout = "cached-v2";
        public const double DefaultProfile = 82.07;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleFactor = 7796;
        public const long StepTools = 4875;
        public const long RetryScore = 4407;
        public const long IdleSize = 9;

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i >> 2) < (879 / 7))
                {
                    acc = (acc - (74 << 1)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
